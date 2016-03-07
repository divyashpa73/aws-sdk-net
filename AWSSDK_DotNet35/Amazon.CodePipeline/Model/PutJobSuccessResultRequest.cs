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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// Container for the parameters to the PutJobSuccessResult operation.
    /// Represents the success of a job as returned to the pipeline by a job worker. Only
    /// used for custom actions.
    /// </summary>
    public partial class PutJobSuccessResultRequest : AmazonCodePipelineRequest
    {
        private string _continuationToken;
        private CurrentRevision _currentRevision;
        private ExecutionDetails _executionDetails;
        private string _jobId;

        /// <summary>
        /// Gets and sets the property ContinuationToken. 
        /// <para>
        /// A system-generated token, such as a AWS CodeDeploy deployment ID, that the successful
        /// job used to complete a job asynchronously. 
        /// </para>
        /// </summary>
        public string ContinuationToken
        {
            get { return this._continuationToken; }
            set { this._continuationToken = value; }
        }

        // Check to see if ContinuationToken property is set
        internal bool IsSetContinuationToken()
        {
            return this._continuationToken != null;
        }

        /// <summary>
        /// Gets and sets the property CurrentRevision. 
        /// <para>
        /// The ID of the current revision of the artifact successfully worked upon by the job.
        /// 
        /// </para>
        /// </summary>
        public CurrentRevision CurrentRevision
        {
            get { return this._currentRevision; }
            set { this._currentRevision = value; }
        }

        // Check to see if CurrentRevision property is set
        internal bool IsSetCurrentRevision()
        {
            return this._currentRevision != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionDetails. 
        /// <para>
        /// The execution details of the successful job, such as the actions taken by the job
        /// worker. 
        /// </para>
        /// </summary>
        public ExecutionDetails ExecutionDetails
        {
            get { return this._executionDetails; }
            set { this._executionDetails = value; }
        }

        // Check to see if ExecutionDetails property is set
        internal bool IsSetExecutionDetails()
        {
            return this._executionDetails != null;
        }

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The unique system-generated ID of the job that succeeded. This is the same ID returned
        /// from PollForJobs.
        /// </para>
        /// </summary>
        public string JobId
        {
            get { return this._jobId; }
            set { this._jobId = value; }
        }

        // Check to see if JobId property is set
        internal bool IsSetJobId()
        {
            return this._jobId != null;
        }

    }
}