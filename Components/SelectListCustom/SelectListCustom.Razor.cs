using Microsoft.AspNetCore.Components;
namespace BlazorSelectList.Components{
    public class SelectListCustomBase<TItem> : ComponentBase
    {
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

        [Parameter]
        public IEnumerable<TItem> Data { get; set; }
    }
}

