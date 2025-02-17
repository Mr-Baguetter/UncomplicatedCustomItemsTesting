using Exiled.API.Enums;
using System.Collections.Generic;
using System.ComponentModel;
using UncomplicatedCustomItems.Interfaces;
using UnityEngine;

namespace UncomplicatedCustomItems.API.Features
{
    public class FlagSettings : IFlagSettings
    {
        /// <summary>
        /// Set the color of the glow if the item has the ItemGlow custom flag
        /// </summary>
        public string GlowColor { get; set; } = "#00FF00";

        public float LifeStealAmount { get; set; } = 8f;

        public float LifeStealPercentage { get; set; } = .5f;
    }
}