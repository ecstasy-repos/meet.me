//Author: Parmanand Kumar
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dashboard.Server.Telemetry;



//Persistence
namespace Dashboard.Server.Persistence
{

    public interface ITelemetryPersistence
    {
        /// <summary>
                /// save the UserCountVsTimeStamp, UserIdVsChatCount, InsincereMember data as png after each session.
        /// </summary>
        /// <param name="intraSessionData"> takes IntraSessionData from Telemetry. </param>
	    public bool save(SessionAnalytics intraSessionData);

        /// <summary>
                 /// append the ServerData into a file after each session end
        /// </summary>
        /// <param name="AllserverData"> takes ServerData from Telemetry to be saved into text file </param> 
        /// <returns>Returns true if saved successfully else returns false</returns>
        public bool saveServerData(ServerDataToSave AllserverData);

        /// <summary>
                 /// retrives the ServerData after end of all of the sessions.
        /// </summary>
        /// <returns>returns List of SeverData</returns>
        public ServerDataToSave retriveAllSeverData();
    }


}
