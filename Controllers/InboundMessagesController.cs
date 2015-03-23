using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Xml;
using K2Core;

namespace LittleBitPushApp.Controllers
{
    public class InboundMessagesController : ApiController
    {
     
  [System.Web.Http.AcceptVerbs("Get","POST")]
        [System.Web.Http.HttpGet]
        
        
        public void Post([FromBody] dynamic body)
        {
     
                K2Core.Workflow.StartWorkflow(@"littlebitworkflow\littlebit", "TEST");
        }
    }

    public class InboundMessage
    {
        public Guid Id { get; set; }
        public Guid MessageId { get; set; }
        public Guid AccountId { get; set; }
        public string MessageText { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public DateTime Now { get; set; }
    }
}