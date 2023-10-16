using Microsoft.AspNetCore.Components;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace BlazorSelectList.Components
{
    public class SelectListJsonBase : ComponentBase
    {
        [Parameter]
        public string Data { get; set; }
        [Parameter]
        public string DefaultText { get; set; }
        [Parameter]
        public string DefaultValue { get; set; }
        [Parameter]
        public string SelectedOptionByValue { get; set; }
        [Parameter]
        public string Name { get; set; }
        [Parameter]
        public string ValueKey { get; set; }
        [Parameter]
        public string TextKey { get; set; }
        public List<string> OptionValues { get; set; }
        public List<string> OptionTextValues { get; set; }

        protected override void OnInitialized()
        {
            OptionValues = new List<string>();
            OptionTextValues = new List<string>();

            JsonNode JsonDataDom = JsonNode.Parse(@Data!)!;

            foreach (var jsonObj in JsonDataDom.AsArray())
            {
                JsonValueKind jvk = jsonObj[@ValueKey].GetValue<JsonElement>().ValueKind;

                if (jvk != JsonValueKind.Number && jvk != JsonValueKind.String)
                {
                    OptionValues.Add("");
                }
                else
                {
                    if (jvk == JsonValueKind.Number)
                    {
                        OptionValues.Add(((int)jsonObj[@ValueKey]).ToString());
                    }
                    else
                    {
                        OptionValues.Add(jsonObj[@ValueKey].GetValue<string>());
                    }
                }

                JsonValueKind jvk2 = jsonObj[@TextKey].GetValue<JsonElement>().ValueKind;

                if (jvk2 != JsonValueKind.Number && jvk2 != JsonValueKind.String)
                {
                    OptionTextValues.Add("");
                }
                else
                {
                    if (jvk2 == JsonValueKind.Number)
                    {
                        OptionTextValues.Add(((int)jsonObj[@TextKey]).ToString());

                    }
                    else
                    {
                        OptionTextValues.Add(jsonObj[@TextKey].GetValue<string>());
                    }
                }

            }
        }

    }
}