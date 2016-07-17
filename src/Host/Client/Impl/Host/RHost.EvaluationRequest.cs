﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using System.Text;
using System.Threading.Tasks;
using Microsoft.Common.Core.Tasks;
using Newtonsoft.Json.Linq;

namespace Microsoft.R.Host.Client {
    partial class RHost {
        private class EvaluationRequest {
            public readonly string Id;
            public readonly string MessageName;
            public readonly string Expression;
            public readonly REvaluationKind Kind;
            public readonly TaskCompletionSourceEx<REvaluationResult> CompletionSource = new TaskCompletionSourceEx<REvaluationResult>();

            public EvaluationRequest(RHost host, string expression, REvaluationKind kind, out JArray message) {
                Expression = expression;
                Kind = kind;

                var nameBuilder = new StringBuilder("?=");
                if (kind.HasFlag(REvaluationKind.Reentrant)) {
                    nameBuilder.Append('@');
                }
                if (kind.HasFlag(REvaluationKind.Cancelable)) {
                    nameBuilder.Append('/');
                }
                if (kind.HasFlag(REvaluationKind.BaseEnv)) {
                    nameBuilder.Append('B');
                }
                if (kind.HasFlag(REvaluationKind.EmptyEnv)) {
                    nameBuilder.Append('E');
                }
                if (kind.HasFlag(REvaluationKind.NoResult)) {
                    nameBuilder.Append('0');
                }
                if (kind.HasFlag(REvaluationKind.Raw)) {
                    nameBuilder.Append('r');
                }
                MessageName = nameBuilder.ToString();

                expression = expression.Replace("\r\n", "\n");

                message = host.CreateMessage(host.CreateMessageHeader(out Id, MessageName, null), expression);
            }
        }
    }
}