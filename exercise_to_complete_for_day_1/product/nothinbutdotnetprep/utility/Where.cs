﻿using System;

namespace nothinbutdotnetprep.utility
{
    public class Where<ItemToFilter>
    {
        public static CriteriaFactory<ItemToFilter, PropertyType> has_a<PropertyType>(Func<ItemToFilter, PropertyType> accessor)
        {
            return new CriteriaFactory<ItemToFilter, PropertyType>(accessor);
        }
        public static ComparisonCriteriaFactory<ItemToFilter, PropertyType> has_an<PropertyType>(Func<ItemToFilter, PropertyType> accessor) where PropertyType : IComparable<PropertyType>
        {
            return new ComparisonCriteriaFactory<ItemToFilter, PropertyType>(accessor);
            
        }
    }
}