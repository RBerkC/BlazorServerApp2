using System;
using System.Collections.Generic;

namespace BlazorServerApp2.Model;

public partial class Viewmodel
{
    public int TodolistId { get; set; }

    public string BrugerId { get; set; } = null!;

    public string? TodoText { get; set; }
}
