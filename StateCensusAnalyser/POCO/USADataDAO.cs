using System;
using System.Collections.Generic;
using System.Text;

namespace StateCensusAnalyser.POCO
{
   public class USADataDAO
    {
        /// <summary>
        /// Define USA State Census Header Variable
        /// </summary>
        public string Id;
        public string state;
        public long population;
        public long housingUnits;
        public double totalArea;
        public double waterArea;
        public double landArea;
        public double density;
        public double housingDensity;
        /// <summary>
        /// Initializes a new instance of the <see cref="USADataDAO"/> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="state"></param>
        /// <param name="population"></param>
        /// <param name="housingUnits"></param>
        /// <param name="totalArea"></param>
        /// <param name="waterArea"></param>
        /// <param name="landArea"></param>
        /// <param name="density"></param>
        /// <param name="housingDensity"></param>
        public USADataDAO(string id,string state,string population,string housingUnits,string totalArea, string waterArea, string landArea, string density, string housingDensity)
        {
            this.Id = id;
            this.state = state;
            this.population = Convert.ToUInt32(population);
            this.housingUnits = Convert.ToUInt32(housingUnits);
            this.totalArea = Convert.ToDouble(totalArea);
            this.waterArea = Convert.ToDouble(waterArea);
            this.landArea = Convert.ToDouble(landArea);
            this.density = Convert.ToDouble(density);
            this.housingDensity = Convert.ToDouble(housingDensity);

        }


    }
}
