using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IFanRegistrationLoginService" in both code and config file together.
[ServiceContract]
public interface IFanRegistrationLoginService
{
    [OperationContract]
    bool RegisterFan(FanLite f, FanLogin fl);

    [OperationContract]
    int FanLogin(string userName, string Password);
}

[DataContract]

public class FanLite
{
    [DataMember]
    public string FanName { set; get; }

    [DataMember]
    public string FanEmail { set; get; }

    [DataMember]
    public string UserName { set; get; }

    [DataMember]
    public string Password { set; get; }

    [DataMember]
    public int FanDateEntered { set; get; }
}
