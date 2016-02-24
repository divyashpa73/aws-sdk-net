/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeFleetPortSettings operation.
    /// Retrieves the port settings for a fleet. Port settings are used to limit incoming
    /// traffic access to game servers in the fleet. To get a fleet's port settings, specify
    /// a fleet ID. If successful, an <a>IpPermission</a> object is returned for the requested
    /// fleet ID. If the requested fleet has been deleted, the result set will be empty.
    /// </summary>
    public partial class DescribeFleetPortSettingsRequest : AmazonGameLiftRequest
    {
        private string _fleetId;

        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        /// Unique identifier for the fleet you want to retrieve port settings for. 
        /// </para>
        /// </summary>
        public string FleetId
        {
            get { return this._fleetId; }
            set { this._fleetId = value; }
        }

        // Check to see if FleetId property is set
        internal bool IsSetFleetId()
        {
            return this._fleetId != null;
        }

    }
}