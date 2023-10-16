using System.Timers;
using System;
using System.Threading;
using Microsoft.AspNetCore.Components;

namespace BlazorSelectList.Components{

public class ClockBase : ComponentBase
{
    public string CurrentDateTime { get; set; } = DateTime.Now.ToLongTimeString();
    private System.Timers.Timer timer;
    protected override void OnInitialized()
    {
        timer = new System.Timers.Timer(999);
        timer.Elapsed += OnTimedEvent;
        timer.AutoReset = true;
        timer.Start();
    }
    private async void OnTimedEvent(object sender, ElapsedEventArgs e)
    {
        await InvokeAsync(() =>
        {
            CurrentDateTime = DateTime.Now.ToLongTimeString();
            StateHasChanged();
        });
    }
}
}


