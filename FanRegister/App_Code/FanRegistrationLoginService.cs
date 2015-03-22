using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "FanRegistrationLoginService" in code, svc and config file together.
public class FanRegistrationLoginService : IFanRegistrationLoginService
{
    FanLoginEntities db = new FanLoginEntities();

    public bool RegisterFan(FanLite f, FanLogin fl)
    {
        bool result = true;
        /*try
        {*/
            PasswordHash ph = new PasswordHash();
            KeyCode kc = new KeyCode();
            int code = kc.GetKeyCode();
            byte[] hashed = ph.HashIt(f.Password, code.ToString());

            Fan fann = new Fan();
            fann.FanName = f.FanName;
            fann.FanEmail = f.FanEmail;
            fann.FanDateEntered = DateTime.Now;

            db.Fans.Add(fann);
            db.SaveChanges();

            FanLogin fanl = new FanLogin();
            fanl.Fan = fann;
            fanl.FanLoginUserName = fl.FanLoginUserName;
            fanl.FanLoginPasswordPlain = fl.FanLoginPasswordPlain;
            fanl.FanLoginRandom = code;
            fanl.FanLoginHashed = hashed;
            fanl.FanLoginDateAdded = DateTime.Now;

            db.FanLogins.Add(fanl);
            db.SaveChanges();
        /*}
        catch
        {
            result = false;
        }*/
        return result;
    }

    public int FanLogin(string userName, string Password)
    {
        int id = 0;

        LoginClass lc = new LoginClass(Password, userName);
        id = lc.ValidateLogin();
        /*LoginHistory lh = new LoginHistory();
        lh.LoginHistoryDateTime = DateTime.Now;
        lh.UserName = userName;

        db.LoginHistories.Add(lh);*/

        db.SaveChanges();

        return id;
    }

}
