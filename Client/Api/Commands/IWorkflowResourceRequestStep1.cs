using Zeebe.Client.Api.Responses;

namespace Zeebe.Client.Api.Commands
{
    public interface IWorkflowResourceRequestStep1
    {

        /// <summary>
        /// Set the BPMN process id of the workflow to create an instance of. This is the static id of the
        /// process in the BPMN XML (i.e. "&#60;bpmn:process id='my-workflow'&#62;").
        /// </summary>
        /// 
        /// <param name="bpmnProcessId">the BPMN process id of the workflow</param>
        /// <returns>the builder for this command</returns>
        IWorkflowResourceRequestStep2 BpmnProcessId(string bpmnProcessId);

        /// <summary>
        /// Set the key of the workflow to create an instance of. The key is assigned by the broker while
        /// deploying the workflow. It can be picked from the deployment or workflow event.
        /// </summary>
        /// 
        /// <param name="workflowKey">the key of the workflow</param>
        /// <returns>the builder for this command</returns>
        IWorkflowResourceRequestStep3 WorkflowKey(long workflowKey);
    }


    public interface IWorkflowResourceRequestStep2
    {
        /// <summary>
        /// Set the version of the workflow to create an instance of. The version is assigned by the
        /// broker while deploying the workflow. It can be picked from the deployment or workflow event.
        /// </summary>
        /// 
        /// <param name="version">the version of the workflow</param>
        /// <returns>the builder for this command</returns>
        IWorkflowResourceRequestStep3 Version(int version);

        /// <summary>
        /// Use the latest version of the workflow to create an instance of.
        /// 
        /// <p>If the latest version was deployed few moments before then it can happen that the new
        /// instance is created of the previous version.
        /// </p>
        /// </summary>
        /// 
        /// <returns>the builder for this command</returns>
        IWorkflowResourceRequestStep3 LatestVersion();
    }

    public interface IWorkflowResourceRequestStep3 : IFinalCommandStep<IWorkflowResourceResponse>
    {
        // the place for new optional parameters
    }
}