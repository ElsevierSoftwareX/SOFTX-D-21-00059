﻿using DecisionMaster.AlgorihtmsLibrary.Interfaces;
using System.Collections.Generic;

namespace DecisionMaster.AlgorihtmsLibrary.Models
{
    public class DecisionConfigurationBase: IDecisionConfiguration
    {
        public List<double> CriteriaRanks { get; set; }
    }
}