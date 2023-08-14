using System.Collections.Generic;

namespace AutoStager
{
    internal static class CellCarriers
    {
        public static Dictionary<string, string> cellCarriers = new Dictionary<string, string>()
        {
            //CELL CARRIER EMAIL LIST
            { "ACS Alaska Wireless", "@msg.acsalaska.com" },
            { "AllTel PCS", "@message.alltel.com" },
            { "Ameritech", "@acswireless.com" },
            { "Appalachian Wireless", "@awsms.com" },
            { "AT&T", "@txt.att.net" },
            { "Bell Atlantic", "@message.bam.com" },
            { "Bell Mobility", "@txt.bellmobility.ca" },
            { "Bell South", "@sms.bellsouth.com" },
            { "Blue Sky Frog", "@blueskyfrog.com" },
            { "Bluegrass Cellular", "@sms.bluecell.com" },
            { "Boost Mobile", "@myboostmobile.com" },
            { "Cellular One", "@cellularone.txtmsg.com" },
            { "CenturyTel", "@messaging.centurytel.net" },
            { "Cingular Wireless", "@mycingular.textmsg.com" },
            { "Clear Net", "@msg.clearnet.com" },
            { "Consumer Cellular", "@mailmymobile.net" },
            { "Cricket", "@sms.cricketwireless.net" },
            { "Edge Wirelesss", "@sms.edgewireless.com" },
            { "MCI", "@mci.com" },
            { "MetroPCS", "@mymetropcs.com" },
            { "Mint Mobile", "@mailmymobile.net" },
            { "Nextel", "@messaging.nextel.com" },
            { "Qwest", "@qwestmp.com" },
            { "Sprint", "@messaging.sprintpcs.com" },
            { "T-Mobile",   "@tmomail.net" },
            { "Tracfone",   "@mmst5.tracfone.com" },
            { "U.S. Cellular",   "@uscc.textmsg.com" },
            { "Verizon", "@vtext.com" },
            { "Virgin Mobile", "@vmobl.com" },
        };


        //CELL CARRIER EMAIL LIST EXTENDED
        //@itelemigcelular.com.br
        //@message.alltel.com--
        //@message.pioneerenidcellular.com
        //@messaging.cellone-sf.com
        //@messaging.centurytel.net--
        //@messaging.sprintpcs.com--
        //@mobile.att.net--
        //@mobile.cell1se.com
        //@mobile.celloneusa.com
        //@mobile.dobson.net
        //@mobile.mycingular.com
        //@mobile.mycingular.net
        //@mobile.surewest.com
        //@msg.acsalaska.com
        //@msg.clearnet.com
        //@msg.mactel.com
        //@msg.myvzw.com
        //@msg.telus.com
        //@mycellular.com
        //@mycingular.com
        //@mycingular.net
        //@mycingular.textmsg.com
        //@mymetropcs.com--
        //@o2.net.br
        //@ondefor.com
        //@pcs.rogers.com
        //@personal-net.com.ar
        //@personal.net.py
        //@portafree.com
        //qwest   @qwest.com--
        //@qwestmp.com
        //@sbcemail.com
        //@sms.bluecell.com
        //@sms.cwjamaica.com
        //@sms.edgewireless.com
        //@sms.hickorytech.com
        //@sms.net.nz
        //@sms.pscel.com
        //@smsc.vzpacifica.net
        //@speedmemo.com
        //@suncom1.com
        //@sungram.com
        //@telesurf.com.py
        //@teletexto.rcp.net.pe
        //@text.houstoncellular.net
        //@text.telus.com
        //@timnet.com
        //@timnet.com.br
        //@tms.suncom.com
        //tmobile   @tmomail.net--
        //@tsttmobile.co.tt
        //@txt.bellmobility.ca
        //@typetalk.ruralcellular.com
        //@unistar.unifon.com.ar
        //@uscc.textmsg.com
        //@voicestream.net
        //verizon   @vtext.com--
        //@wireless.bellsouth.com 

        //msg.acsalaska.com - ACS Wireless--
        //message.alltel.com - Alltel--
        //digitaledge.acswireless.com - Ameritech--
        //awsms.com - Appalachian Wireless--
        //mobile.att.net - AT&T Wireless--
        //dpcs.mobile.att.net - AT&T Pocketnet
        //sms.edgewireless.com - AT&T Edgewireless
        //wireless.bellsouth.com - Bell South Cellular 1
        //bellsouthwirelessemail.com - Bell South Cellular 2
        //sms.bluecell.com - Bluegrass Cellular
        //typetalk.ruralcellular.com - Cellular 2000
        //cwwsms.com - Carolina West
        //mobile.celloneusa.com - Cellular One 1
        //c1usa.com - Cellular One 2
        //c1email.com - Cellular One-Amarillo
        //typetalk.ruralcellular.com - Cellular One-Bend
        //sbcemail.com - Cellular One-Boston
        //cellone-ms.com - Cellular One-Mississippi
        //mycellone.net - Cellular One-NE Texas
        //sms.iowaone.net - Cellular One-NW Iowa
        //utext.com - Cellular One-Rural Cellular
        //mobile.c1-slo.com - Cellular One-SLO
        //csouth1.com - Cellular South
        //gocbw.com - Cincinnati Bell Wireless
        //mycingular.com - Cingular Wireless 1
        //mycingular.net - Cingular Wireless 2
        //mobile.mycingular.com - Cingular Wireless 3
        //mobile.mycingular.net - Cingular Wireless 4
        //corrwireless.net - Corr Wireless
        //mobile.dobsoncellular.com - Dobson Cellular
        //sms.hickorytech.com - HickoryTech
        //text.houstoncellular.net - Houston Cellular
        //clearlydigital.com - Midwest Wireless
        //message.pioneerenidcellular.com - Pioneer Enid Cellular
        //smsmail.plateautel.net - Plateau Wireless
        //sms.pscel.com - PSC Wireless
        //mail.data1source.com - PTSI Cellular
        //mobile.att.net - Rogers AT&T
        //pcs.rogers.com - Rogers AT&T
        //email2go.com - Rogers AT&T
        //email.swbw.com - Southwestern Bell
        //tms.suncom.com - Suncom
        //suncom1.com - Suncom
        //sungram.com - Suncom
        //typetalk.ruralcellular.com - Unicel 1
        //uscc.textmsg.com - US Cellular 1
        //email.uscc.net - US Cellular 2
        //uscc.net - US Cellular 3
        //smsc.vzpacifica.net - Verizon Guam/Micronesia
        //sms.wcc.net - West Central Wireless
        //msg.telus.com - Telus Mobility
        //txt.bellmobility.com -Bell Mobility
        //pcs.rogers.com - Rogers Mobility
        //wirefree.informe.ca - Aliant Mobility
        //pcs.sasktelmobility.com - SaskTel
        //txt.bellmobility.ca - Bell Mobility Canada

    }
}
