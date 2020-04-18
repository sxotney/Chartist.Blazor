﻿using System.Collections.Generic;

namespace Chartist.Blazor 
{
    /// <summary>
    /// Defines the basic chart data for all chart types
    /// </summary>
    public class ChartDataBase
    {
        /// <summary>
        /// Gets or sets the labels.
        /// </summary>
        /// <value>
        /// The labels.
        /// </value>
        public List<string> Labels { get; set; }
    }
}
