/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.schedulerx2.Model.V20190430;

namespace Aliyun.Acs.schedulerx2.Transform.V20190430
{
    public class ExecuteJobResponseUnmarshaller
    {
        public static ExecuteJobResponse Unmarshall(UnmarshallerContext context)
        {
			ExecuteJobResponse executeJobResponse = new ExecuteJobResponse();

			executeJobResponse.HttpResponse = context.HttpResponse;
			executeJobResponse.RequestId = context.StringValue("ExecuteJob.RequestId");
			executeJobResponse.Code = context.IntegerValue("ExecuteJob.Code");
			executeJobResponse.Message = context.StringValue("ExecuteJob.Message");
			executeJobResponse.Success = context.BooleanValue("ExecuteJob.Success");

			ExecuteJobResponse.ExecuteJob_Data data = new ExecuteJobResponse.ExecuteJob_Data();
			data.JobInstanceId = context.LongValue("ExecuteJob.Data.JobInstanceId");
			executeJobResponse.Data = data;
        
			return executeJobResponse;
        }
    }
}
