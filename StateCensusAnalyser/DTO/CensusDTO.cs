using StateCensusAnalyser.POCO;
using System;
using System.Collections.Generic;
using System.Text;

namespace StateCensusAnalyser.DTO
{
    public class CensusDTO
    {
        public int serialNumber;
        public string stateName;
        public string state;
        public int tin;
        public string stateCode;
        public long population;
        public long area;
        public long density;
        public long housingUnits;
        public double totalArea;
        public double waterArea;
        public double landArea;
        public double populationDensity;
        public double housingDensity;
        public string usaId;
        public string usaState;
        public long usaPopulation;
        public long usaHousingUnits;
        public double usaTotalArea;
        public double usaWaterArea;
        public double usaLandArea;
        public double usaDensity;
        public double usaHousingDensity;

        /// <summary>
        /// Initializes a new instance of the <see cref="CensusDTO"/> class.
        /// </summary>
        /// <param name="stateCodeDAO">The state code DAO.</param>
        public CensusDTO(StateCodeDAO stateCodeDAO)
        {
            this.serialNumber = stateCodeDAO.serialNumber;
            this.stateName = stateCodeDAO.stateName;
            this.tin = stateCodeDAO.tin;
            this.stateCode = stateCodeDAO.stateCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CensusDTO"/> class.
        /// </summary>
        /// <param name="censusDataDAO">The census data DAO.</param>
        public CensusDTO(CensusDataDAO censusDataDAO)
        {
            this.state = censusDataDAO.state;
            this.population = censusDataDAO.population;
            this.area = censusDataDAO.area;
            this.density = censusDataDAO.density;
        }
        public CensusDTO(USADataDAO usaDataDao)
        {
            this.usaId = usaDataDao.Id;
            this.usaState = usaDataDao.state;
            this.usaPopulation = usaDataDao.population;
            this.usaHousingUnits = usaDataDao.housingUnits;
            this.usaTotalArea = usaDataDao.totalArea;
            this.usaWaterArea = usaDataDao.waterArea;
            this.usaLandArea = usaDataDao.landArea;
            this.usaDensity = usaDataDao.density;
            this.usaHousingDensity = usaDataDao.housingDensity;
        }
    }
}


