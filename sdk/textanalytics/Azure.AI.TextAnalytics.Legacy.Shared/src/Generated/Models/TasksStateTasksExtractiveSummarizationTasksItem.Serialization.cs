// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.AI.TextAnalytics.Legacy;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Legacy.Models
{
    internal partial class TasksStateTasksExtractiveSummarizationTasksItem
    {
        internal static TasksStateTasksExtractiveSummarizationTasksItem DeserializeTasksStateTasksExtractiveSummarizationTasksItem(JsonElement element)
        {
            Optional<ExtractiveSummarizationResult> results = default;
            DateTimeOffset lastUpdateDateTime = default;
            Optional<string> taskName = default;
            State status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("results"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    results = ExtractiveSummarizationResult.DeserializeExtractiveSummarizationResult(property.Value);
                    continue;
                }
                if (property.NameEquals("lastUpdateDateTime"))
                {
                    lastUpdateDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("taskName"))
                {
                    taskName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    status = property.Value.GetString().ToState();
                    continue;
                }
            }
            return new TasksStateTasksExtractiveSummarizationTasksItem(lastUpdateDateTime, taskName.Value, status, results.Value);
        }
    }
}
