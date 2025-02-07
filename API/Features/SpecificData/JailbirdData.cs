﻿using UncomplicatedCustomItems.Interfaces.SpecificData;

namespace UncomplicatedCustomItems.API.Features.SpecificData
{
    public class JailbirdData : Data, IJailbirdData
    {
        /// <summary>
        /// Gets or sets the amount of damage dealt with a Jailbird melee hit.
        /// </summary>
        public float MeleeDamage { get; set; }

        /// <summary>
        /// Gets or sets the amount of damage dealt with a Jailbird charge hit.
        /// </summary>
        public float ChargeDamage { get; set; }

        /// <summary>
        /// Gets or sets the amount of time in seconds that the <see cref="CustomPlayerEffects.Flashed"/> effect will be applied on being hit.
        /// </summary>
        public float FlashDuration { get; set; }

        /// <summary>
        /// Gets or sets the radius of the Jailbird's hit register.
        /// </summary>
        public float Radius { get; set; }

        /// <summary>
        /// Gets or sets the total amount of damage dealt with the Jailbird.
        /// </summary>
        public float TotalDamageDealt { get; set; }

        /// <summary>
        /// Gets or sets the number of times the item has been charged and used.
        /// </summary>
        public int TotalCharges { get; set; }
    }
}
