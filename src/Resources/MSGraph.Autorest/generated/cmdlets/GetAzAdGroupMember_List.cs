// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Cmdlets
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Extensions;
    using System;

    /// <summary>
    /// UMembers of this group, who can be users, devices, other groups, or service principals. Supports the List members, Add
    /// member, and Remove member operations. Nullable. Supports $expand including nested $select. For example, /groups?$filter=startsWith(displayName,'Role')&$select=id,displayName&$expand=members($select=id,userPrincipalName,displayName).
    /// </summary>
    /// <remarks>
    /// [OpenAPI] ListMembers=>GET:"/groups/{group-id}/members"
    /// </remarks>
    [global::Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.InternalExport]
    [global::System.Management.Automation.Cmdlet(global::System.Management.Automation.VerbsCommon.Get, @"AzADGroupMember_List", SupportsPaging = true)]
    [global::System.Management.Automation.OutputType(typeof(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDirectoryObject))]
    [global::Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Description(@"UMembers of this group, who can be users, devices, other groups, or service principals. Supports the List members, Add member, and Remove member operations. Nullable. Supports $expand including nested $select. For example, /groups?$filter=startsWith(displayName,'Role')&$select=id,displayName&$expand=members($select=id,userPrincipalName,displayName).")]
    [global::Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Generated]
    public partial class GetAzADGroupMember_List : global::System.Management.Automation.PSCmdlet,
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IEventListener
    {
        /// <summary>A unique id generatd for the this cmdlet when it is instantiated.</summary>
        private string __correlationId = System.Guid.NewGuid().ToString();

        /// <summary>A copy of the Invocation Info (necessary to allow asJob to clone this cmdlet)</summary>
        private global::System.Management.Automation.InvocationInfo __invocationInfo;

        /// <summary>A unique id generatd for the this cmdlet when ProcessRecord() is called.</summary>
        private string __processRecordId;

        /// <summary>
        /// The <see cref="global::System.Threading.CancellationTokenSource" /> for this operation.
        /// </summary>
        private global::System.Threading.CancellationTokenSource _cancellationTokenSource = new global::System.Threading.CancellationTokenSource();

        /// <summary>A flag to tell whether it is the first onOK call.</summary>
        private bool _isFirst = true;

        /// <summary>Link to retrieve next page.</summary>
        private string _nextLink;

        /// <summary>Wait for .NET debugger to attach</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Wait for .NET debugger to attach")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter Break { get; set; }

        /// <summary>The reference to the client API class.</summary>
        public Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.MSGraph Client => Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Module.Instance.ClientAPI;

        /// <summary>Backing field for <see cref="Count" /> property.</summary>
        private global::System.Management.Automation.SwitchParameter _count;

        /// <summary>Include count of items</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Include count of items")]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Include count of items",
        SerializedName = @"$count",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.ParameterCategory.Query)]
        public global::System.Management.Automation.SwitchParameter Count { get => this._count; set => this._count = value; }

        /// <summary>
        /// The credentials, account, tenant, and subscription used for communication with Azure
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The credentials, account, tenant, and subscription used for communication with Azure.")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::System.Management.Automation.Alias("AzureRMContext", "AzureCredential")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.ParameterCategory.Azure)]
        public global::System.Management.Automation.PSObject DefaultProfile { get; set; }

        /// <summary>Backing field for <see cref="Expand" /> property.</summary>
        private string[] _expand;

        /// <summary>Expand related entities</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Expand related entities")]
        [global::System.Management.Automation.AllowEmptyCollection]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Expand related entities",
        SerializedName = @"$expand",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.ParameterCategory.Query)]
        public string[] Expand { get => this._expand; set => this._expand = value; }

        /// <summary>Backing field for <see cref="Filter" /> property.</summary>
        private string _filter;

        /// <summary>Filter items by property values</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Filter items by property values")]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Filter items by property values",
        SerializedName = @"$filter",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.ParameterCategory.Query)]
        public string Filter { get => this._filter; set => this._filter = value; }

        /// <summary>Backing field for <see cref="GroupId" /> property.</summary>
        private string _groupId;

        /// <summary>key: id of group</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "key: id of group")]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"key: id of group",
        SerializedName = @"group-id",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.ParameterCategory.Path)]
        public string GroupId { get => this._groupId; set => this._groupId = value; }

        /// <summary>SendAsync Pipeline Steps to be appended to the front of the pipeline</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be appended to the front of the pipeline")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.ParameterCategory.Runtime)]
        public Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.SendAsyncStep[] HttpPipelineAppend { get; set; }

        /// <summary>SendAsync Pipeline Steps to be prepended to the front of the pipeline</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be prepended to the front of the pipeline")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.ParameterCategory.Runtime)]
        public Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.SendAsyncStep[] HttpPipelinePrepend { get; set; }

        /// <summary>Accessor for our copy of the InvocationInfo.</summary>
        public global::System.Management.Automation.InvocationInfo InvocationInformation { get => __invocationInfo = __invocationInfo ?? this.MyInvocation ; set { __invocationInfo = value; } }

        /// <summary>
        /// <see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IEventListener" /> cancellation delegate. Stops the cmdlet when called.
        /// </summary>
        global::System.Action Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IEventListener.Cancel => _cancellationTokenSource.Cancel;

        /// <summary><see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IEventListener" /> cancellation token.</summary>
        global::System.Threading.CancellationToken Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IEventListener.Token => _cancellationTokenSource.Token;

        /// <summary>Backing field for <see cref="Orderby" /> property.</summary>
        private string[] _orderby;

        /// <summary>Order items by property values</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Order items by property values")]
        [global::System.Management.Automation.AllowEmptyCollection]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Order items by property values",
        SerializedName = @"$orderby",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.ParameterCategory.Query)]
        public string[] Orderby { get => this._orderby; set => this._orderby = value; }

        /// <summary>
        /// The instance of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.HttpPipeline" /> that the remote call will use.
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.HttpPipeline Pipeline { get; set; }

        /// <summary>The URI for the proxy server to use</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "The URI for the proxy server to use")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.ParameterCategory.Runtime)]
        public global::System.Uri Proxy { get; set; }

        /// <summary>Credentials for a proxy server to use for the remote call</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Credentials for a proxy server to use for the remote call")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.ParameterCategory.Runtime)]
        public global::System.Management.Automation.PSCredential ProxyCredential { get; set; }

        /// <summary>Use the default credentials for the proxy</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Use the default credentials for the proxy")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter ProxyUseDefaultCredentials { get; set; }

        /// <summary>Backing field for <see cref="Search" /> property.</summary>
        private string _search;

        /// <summary>Search items by search phrases</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Search items by search phrases")]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Search items by search phrases",
        SerializedName = @"$search",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.ParameterCategory.Query)]
        public string Search { get => this._search; set => this._search = value; }

        /// <summary>Backing field for <see cref="Select" /> property.</summary>
        private string[] _select;

        /// <summary>Select properties to be returned</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Select properties to be returned")]
        [global::System.Management.Automation.AllowEmptyCollection]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Select properties to be returned",
        SerializedName = @"$select",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.ParameterCategory.Query)]
        public string[] Select { get => this._select; set => this._select = value; }

        /// <summary>
        /// <c>overrideOnDefault</c> will be called before the regular onDefault has been processed, allowing customization of what
        /// happens on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10Beta.IOdataError"
        /// /> from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onDefault method should be processed, or if the method should
        /// return immediately (set to true to skip further processing )</param>

        partial void overrideOnDefault(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10Beta.IOdataError> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// <c>overrideOnOk</c> will be called before the regular onOk has been processed, allowing customization of what happens
        /// on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10Beta.ICollectionOfDirectoryObjectAutoGenerated"
        /// /> from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onOk method should be processed, or if the method should return
        /// immediately (set to true to skip further processing )</param>

        partial void overrideOnOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10Beta.ICollectionOfDirectoryObjectAutoGenerated> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// (overrides the default BeginProcessing method in global::System.Management.Automation.PSCmdlet)
        /// </summary>
        protected override void BeginProcessing()
        {
            var telemetryId = Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Module.Instance.GetTelemetryId.Invoke();
            if (telemetryId != "" && telemetryId != "internal")
            {
                __correlationId = telemetryId;
            }
            Module.Instance.SetProxyConfiguration(Proxy, ProxyCredential, ProxyUseDefaultCredentials);
            if (Break)
            {
                Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.AttachDebugger.Break();
            }
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Events.CmdletBeginProcessing).Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
        }

        /// <summary>Performs clean-up after the command execution</summary>
        protected override void EndProcessing()
        {

        }

        /// <summary>
        /// Intializes a new instance of the <see cref="GetAzADGroupMember_List" /> cmdlet class.
        /// </summary>
        public GetAzADGroupMember_List()
        {

        }

        /// <summary>Handles/Dispatches events during the call to the REST service.</summary>
        /// <param name="id">The message id</param>
        /// <param name="token">The message cancellation token. When this call is cancelled, this should be <c>true</c></param>
        /// <param name="messageData">Detailed message data for the message event.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the message is completed.
        /// </returns>
         async global::System.Threading.Tasks.Task Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IEventListener.Signal(string id, global::System.Threading.CancellationToken token, global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.EventData> messageData)
        {
            using( NoSynchronizationContext )
            {
                if (token.IsCancellationRequested)
                {
                    return ;
                }

                switch ( id )
                {
                    case Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Events.Verbose:
                    {
                        WriteVerbose($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Events.Warning:
                    {
                        WriteWarning($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Events.Information:
                    {
                        var data = messageData();
                        WriteInformation(data.Message, new string[]{});
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Events.Debug:
                    {
                        WriteDebug($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Events.Error:
                    {
                        WriteError(new global::System.Management.Automation.ErrorRecord( new global::System.Exception(messageData().Message), string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null ) );
                        return ;
                    }
                }
                await Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Module.Instance.Signal(id, token, messageData, (i,t,m) => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IEventListener)this).Signal(i,t,()=> Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.EventDataConverter.ConvertFrom( m() ) as Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.EventData ), InvocationInformation, this.ParameterSetName, __correlationId, __processRecordId, null );
                if (token.IsCancellationRequested)
                {
                    return ;
                }
                WriteDebug($"{id}: {(messageData().Message ?? global::System.String.Empty)}");
            }
        }

        /// <summary>Performs execution of the command.</summary>
        protected override void ProcessRecord()
        {
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Events.CmdletProcessRecordStart).Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
            __processRecordId = System.Guid.NewGuid().ToString();
            try
            {
                // work
                using( var asyncCommandRuntime = new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.PowerShell.AsyncCommandRuntime(this, ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IEventListener)this).Token) )
                {
                    asyncCommandRuntime.Wait( ProcessRecordAsync(),((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IEventListener)this).Token);
                }
            }
            catch (global::System.AggregateException aggregateException)
            {
                // unroll the inner exceptions to get the root cause
                foreach( var innerException in aggregateException.Flatten().InnerExceptions )
                {
                    ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Events.CmdletException, $"{innerException.GetType().Name} - {innerException.Message} : {innerException.StackTrace}").Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    // Write exception out to error channel.
                    WriteError( new global::System.Management.Automation.ErrorRecord(innerException,string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null) );
                }
            }
            catch (global::System.Exception exception) when ((exception as System.Management.Automation.PipelineStoppedException)== null || (exception as System.Management.Automation.PipelineStoppedException).InnerException != null)
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Events.CmdletException, $"{exception.GetType().Name} - {exception.Message} : {exception.StackTrace}").Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                // Write exception out to error channel.
                WriteError( new global::System.Management.Automation.ErrorRecord(exception,string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null) );
            }
            finally
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Events.CmdletProcessRecordEnd).Wait();
            }
        }

        /// <summary>Performs execution of the command, working asynchronously if required.</summary>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        protected async global::System.Threading.Tasks.Task ProcessRecordAsync()
        {
            using( NoSynchronizationContext )
            {
                await ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Events.CmdletGetPipeline); if( ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                Pipeline = Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Module.Instance.CreatePipeline(InvocationInformation, __correlationId, __processRecordId, this.ParameterSetName);
                if (null != HttpPipelinePrepend)
                {
                    Pipeline.Prepend((this.CommandRuntime as Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelinePrepend) ?? HttpPipelinePrepend);
                }
                if (null != HttpPipelineAppend)
                {
                    Pipeline.Append((this.CommandRuntime as Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelineAppend) ?? HttpPipelineAppend);
                }
                // get the client instance
                try
                {
                    await ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Events.CmdletBeforeAPICall); if( ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    await this.Client.GroupsListMembers(GroupId, this.InvocationInformation.BoundParameters.ContainsKey("Search") ? Search : null, this.InvocationInformation.BoundParameters.ContainsKey("Filter") ? Filter : null, this.InvocationInformation.BoundParameters.ContainsKey("Count") ? Count : default(global::System.Management.Automation.SwitchParameter?), this.InvocationInformation.BoundParameters.ContainsKey("Orderby") ? Orderby : null /* arrayOf */, this.InvocationInformation.BoundParameters.ContainsKey("Select") ? Select : null /* arrayOf */, this.InvocationInformation.BoundParameters.ContainsKey("Expand") ? Expand : null /* arrayOf */, onOk, onDefault, this, Pipeline);
                    await ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Events.CmdletAfterAPICall); if( ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                }
                catch (Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.UndeclaredResponseException urexception)
                {
                    WriteError(new global::System.Management.Automation.ErrorRecord(urexception, urexception.StatusCode.ToString(), global::System.Management.Automation.ErrorCategory.InvalidOperation, new {  GroupId=GroupId,Search=this.InvocationInformation.BoundParameters.ContainsKey("Search") ? Search : null,Filter=this.InvocationInformation.BoundParameters.ContainsKey("Filter") ? Filter : null,Count=this.InvocationInformation.BoundParameters.ContainsKey("Count") ? Count : default(global::System.Management.Automation.SwitchParameter?),Orderby=this.InvocationInformation.BoundParameters.ContainsKey("Orderby") ? Orderby : null /* arrayOf */,Select=this.InvocationInformation.BoundParameters.ContainsKey("Select") ? Select : null /* arrayOf */,Expand=this.InvocationInformation.BoundParameters.ContainsKey("Expand") ? Expand : null /* arrayOf */})
                    {
                      ErrorDetails = new global::System.Management.Automation.ErrorDetails(urexception.Message) { RecommendedAction = urexception.Action }
                    });
                }
                finally
                {
                    await ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Events.CmdletProcessRecordAsyncEnd);
                }
            }
        }

        /// <summary>Interrupts currently running code within the command.</summary>
        protected override void StopProcessing()
        {
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IEventListener)this).Cancel();
            base.StopProcessing();
        }

        /// <summary>
        /// a delegate that is called when the remote service returns default (any response code not handled elsewhere).
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10Beta.IOdataError"
        /// /> from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onDefault(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10Beta.IOdataError> response)
        {
            using( NoSynchronizationContext )
            {
                var _returnNow = global::System.Threading.Tasks.Task<bool>.FromResult(false);
                overrideOnDefault(responseMessage, response, ref _returnNow);
                // if overrideOnDefault has returned true, then return right away.
                if ((null != _returnNow && await _returnNow))
                {
                    return ;
                }
                // Error Response : default
                var code = (await response)?.Error?.Code;
                var message = (await response)?.Error?.Message;
                if ((null == code || null == message))
                {
                    // Unrecognized Response. Create an error record based on what we have.
                    var ex = new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10Beta.IOdataError>(responseMessage, await response);
                    WriteError( new global::System.Management.Automation.ErrorRecord(ex, ex.Code, global::System.Management.Automation.ErrorCategory.InvalidOperation, new { GroupId=GroupId, Search=this.InvocationInformation.BoundParameters.ContainsKey("Search") ? Search : null, Filter=this.InvocationInformation.BoundParameters.ContainsKey("Filter") ? Filter : null, Count=this.InvocationInformation.BoundParameters.ContainsKey("Count") ? Count : default(global::System.Management.Automation.SwitchParameter?), Orderby=this.InvocationInformation.BoundParameters.ContainsKey("Orderby") ? Orderby : null /* arrayOf */, Select=this.InvocationInformation.BoundParameters.ContainsKey("Select") ? Select : null /* arrayOf */, Expand=this.InvocationInformation.BoundParameters.ContainsKey("Expand") ? Expand : null /* arrayOf */ })
                    {
                      ErrorDetails = new global::System.Management.Automation.ErrorDetails(ex.Message) { RecommendedAction = ex.Action }
                    });
                }
                else
                {
                    WriteError( new global::System.Management.Automation.ErrorRecord(new global::System.Exception($"[{code}] : {message}"), code?.ToString(), global::System.Management.Automation.ErrorCategory.InvalidOperation, new { GroupId=GroupId, Search=this.InvocationInformation.BoundParameters.ContainsKey("Search") ? Search : null, Filter=this.InvocationInformation.BoundParameters.ContainsKey("Filter") ? Filter : null, Count=this.InvocationInformation.BoundParameters.ContainsKey("Count") ? Count : default(global::System.Management.Automation.SwitchParameter?), Orderby=this.InvocationInformation.BoundParameters.ContainsKey("Orderby") ? Orderby : null /* arrayOf */, Select=this.InvocationInformation.BoundParameters.ContainsKey("Select") ? Select : null /* arrayOf */, Expand=this.InvocationInformation.BoundParameters.ContainsKey("Expand") ? Expand : null /* arrayOf */ })
                    {
                      ErrorDetails = new global::System.Management.Automation.ErrorDetails(message) { RecommendedAction = global::System.String.Empty }
                    });
                }
            }
        }

        /// <summary>a delegate that is called when the remote service returns 200 (OK).</summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10Beta.ICollectionOfDirectoryObjectAutoGenerated"
        /// /> from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10Beta.ICollectionOfDirectoryObjectAutoGenerated> response)
        {
            using( NoSynchronizationContext )
            {
                var _returnNow = global::System.Threading.Tasks.Task<bool>.FromResult(false);
                overrideOnOk(responseMessage, response, ref _returnNow);
                // if overrideOnOk has returned true, then return right away.
                if ((null != _returnNow && await _returnNow))
                {
                    return ;
                }
                // onOk - response for 200 / application/json
                // clientside pagination enabled
                // response should be returning an array of some kind. +Pageable
                // pageable / value / @odata.nextLink
                var result = await response;
                if ((ulong)result.Value.Length <= this.PagingParameters.Skip)
                {
                    this.PagingParameters.Skip = this.PagingParameters.Skip - (ulong)result.Value.Length;
                }
                else
                {
                    ulong toRead = Math.Min(this.PagingParameters.First, (ulong)result.Value.Length - this.PagingParameters.Skip);
                    var requiredResult = result.Value.SubArray((int)this.PagingParameters.Skip, (int)toRead);
                    WriteObject(requiredResult, true);
                    this.PagingParameters.Skip = 0;
                    this.PagingParameters.First = this.PagingParameters.First <= toRead ? 0 : this.PagingParameters.First - toRead;
                }
                _nextLink = result.OdataNextLink;
                if (_isFirst)
                {
                    _isFirst = false;
                    while (_nextLink != null && this.PagingParameters.First > 0)
                    {
                        if (responseMessage.RequestMessage is System.Net.Http.HttpRequestMessage requestMessage )
                        {
                            requestMessage = requestMessage.Clone(new global::System.Uri( _nextLink ),Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Method.Get );
                            await ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Events.FollowingNextLink); if( ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                            await this.Client.GroupsListMembers_Call(requestMessage, onOk, onDefault, this, Pipeline);
                        }
                    }
                }
            }
        }
    }
}