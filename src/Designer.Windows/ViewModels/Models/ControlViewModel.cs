﻿using System.Collections.ObjectModel;

namespace Designer.Windows.ViewModels.Models;

public class GroupedControlViewModel : BindableBase
{
    public string Name { get; set; }

    public ObservableCollection<ControlViewModel> Controls { get; } = new ObservableCollection<ControlViewModel>();

    public GroupedControlViewModel(string name)
    {
        Name = name;
    }
}

public class ControlViewModel :BindableBase
{
    public string Source { get; set; }

    public string Name { get; set; }

    public ControlViewModel(string name, string source)
    {
        Name = name;
        Source = source;
    }
}