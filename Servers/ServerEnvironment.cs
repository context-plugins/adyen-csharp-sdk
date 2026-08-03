using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Servers;

[JsonConverter(typeof(StringEnumConverter<ServerEnvironment>))]
public record ServerEnvironment : StringEnum<ServerEnvironment>
{
    /// <summary>
    /// Test Environment
    /// </summary>
    public static readonly ServerEnvironment Production = new("production");
    /// <summary>
    /// Test Environment
    /// </summary>
    public static readonly ServerEnvironment Environment2 = new("environment2");
    /// <summary>
    /// Test Environment
    /// </summary>
    public static readonly ServerEnvironment Environment3 = new("environment3");
    /// <summary>
    /// Test Environment
    /// </summary>
    public static readonly ServerEnvironment Environment4 = new("environment4");
    /// <summary>
    /// Test Environment
    /// </summary>
    public static readonly ServerEnvironment Environment5 = new("environment5");
    /// <summary>
    /// Test Environment
    /// </summary>
    public static readonly ServerEnvironment Environment6 = new("environment6");
    /// <summary>
    /// Test Environment
    /// </summary>
    public static readonly ServerEnvironment Environment7 = new("environment7");
    /// <summary>
    /// Test Environment
    /// </summary>
    public static readonly ServerEnvironment Environment8 = new("environment8");
    /// <summary>
    /// Test Environment
    /// </summary>
    public static readonly ServerEnvironment Environment9 = new("environment9");
    /// <summary>
    /// Test Environment
    /// </summary>
    public static readonly ServerEnvironment Environment10 = new("environment10");
    /// <summary>
    /// Test Environment
    /// </summary>
    public static readonly ServerEnvironment Environment11 = new("environment11");
    /// <summary>
    /// Test Environment
    /// </summary>
    public static readonly ServerEnvironment Environment12 = new("environment12");
    /// <summary>
    /// Test Environment
    /// </summary>
    public static readonly ServerEnvironment Environment13 = new("environment13");
    /// <summary>
    /// Test Environment
    /// </summary>
    public static readonly ServerEnvironment Environment14 = new("environment14");
    /// <summary>
    /// Test Environment
    /// </summary>
    public static readonly ServerEnvironment Environment15 = new("environment15");
    /// <summary>
    /// Test Environment
    /// </summary>
    public static readonly ServerEnvironment Environment16 = new("environment16");
    /// <summary>
    /// Test Environment
    /// </summary>
    public static readonly ServerEnvironment Environment17 = new("environment17");
    /// <summary>
    /// Test Environment
    /// </summary>
    public static readonly ServerEnvironment Environment18 = new("environment18");
    /// <summary>
    /// Test Environment
    /// </summary>
    public static readonly ServerEnvironment Environment19 = new("environment19");
    /// <summary>
    /// Test Environment
    /// </summary>
    public static readonly ServerEnvironment Environment20 = new("environment20");
    /// <summary>
    /// Test Environment
    /// </summary>
    public static readonly ServerEnvironment Environment21 = new("environment21");
    /// <summary>
    /// Test Environment
    /// </summary>
    public static readonly ServerEnvironment Environment22 = new("environment22");
    /// <summary>
    /// Test Environment
    /// </summary>
    public static readonly ServerEnvironment Environment23 = new("environment23");
    /// <summary>
    /// Test Environment
    /// </summary>
    public static readonly ServerEnvironment Environment24 = new("environment24");
    /// <summary>
    /// Test Environment
    /// </summary>
    public static readonly ServerEnvironment Environment25 = new("environment25");
    /// <summary>
    /// Test Environment
    /// </summary>
    public static readonly ServerEnvironment Environment26 = new("environment26");
    /// <summary>
    /// Test Environment
    /// </summary>
    public static readonly ServerEnvironment Environment27 = new("environment27");
    /// <summary>
    /// Test Environment
    /// </summary>
    public static readonly ServerEnvironment Environment28 = new("environment28");
    /// <summary>
    /// Test Environment
    /// </summary>
    public static readonly ServerEnvironment Environment29 = new("environment29");
    /// <summary>
    /// Test Environment
    /// </summary>
    public static readonly ServerEnvironment Environment30 = new("environment30");
    /// <summary>
    /// Live Environment
    /// </summary>
    public static readonly ServerEnvironment Environment31 = new("environment31");
    /// <summary>
    /// Live Environment
    /// </summary>
    public static readonly ServerEnvironment Environment32 = new("environment32");
    /// <summary>
    /// Live Environment
    /// </summary>
    public static readonly ServerEnvironment Environment33 = new("environment33");
    /// <summary>
    /// Live Environment
    /// </summary>
    public static readonly ServerEnvironment Environment34 = new("environment34");
    /// <summary>
    /// Live Environment
    /// </summary>
    public static readonly ServerEnvironment Environment35 = new("environment35");
    /// <summary>
    /// Live Environment
    /// </summary>
    public static readonly ServerEnvironment Environment36 = new("environment36");
    /// <summary>
    /// Live Environment
    /// </summary>
    public static readonly ServerEnvironment Environment37 = new("environment37");
    /// <summary>
    /// Live Environment
    /// </summary>
    public static readonly ServerEnvironment Environment38 = new("environment38");
    /// <summary>
    /// Live Environment
    /// </summary>
    public static readonly ServerEnvironment Environment39 = new("environment39");
    /// <summary>
    /// Live Environment
    /// </summary>
    public static readonly ServerEnvironment Environment40 = new("environment40");
    /// <summary>
    /// Live Environment
    /// </summary>
    public static readonly ServerEnvironment Environment41 = new("environment41");
    /// <summary>
    /// Live Environment
    /// </summary>
    public static readonly ServerEnvironment Environment42 = new("environment42");
    /// <summary>
    /// Live Environment
    /// </summary>
    public static readonly ServerEnvironment Environment43 = new("environment43");
    /// <summary>
    /// Live Environment
    /// </summary>
    public static readonly ServerEnvironment Environment44 = new("environment44");
    /// <summary>
    /// Live Environment
    /// </summary>
    public static readonly ServerEnvironment Environment45 = new("environment45");
    /// <summary>
    /// Live Environment
    /// </summary>
    public static readonly ServerEnvironment Environment46 = new("environment46");
    /// <summary>
    /// Live Environment
    /// </summary>
    public static readonly ServerEnvironment Environment47 = new("environment47");
    /// <summary>
    /// Live Environment
    /// </summary>
    public static readonly ServerEnvironment Environment48 = new("environment48");
    /// <summary>
    /// Live Environment
    /// </summary>
    public static readonly ServerEnvironment Environment49 = new("environment49");
    /// <summary>
    /// Live Environment
    /// </summary>
    public static readonly ServerEnvironment Environment50 = new("environment50");
    /// <summary>
    /// Live Environment
    /// </summary>
    public static readonly ServerEnvironment Environment51 = new("environment51");
    /// <summary>
    /// Live Environment
    /// </summary>
    public static readonly ServerEnvironment Environment52 = new("environment52");
    /// <summary>
    /// Live Environment
    /// </summary>
    public static readonly ServerEnvironment Environment53 = new("environment53");
    /// <summary>
    /// Live Environment
    /// </summary>
    public static readonly ServerEnvironment Environment54 = new("environment54");
    /// <summary>
    /// Live Environment
    /// </summary>
    public static readonly ServerEnvironment Environment55 = new("environment55");
    /// <summary>
    /// Live Environment
    /// </summary>
    public static readonly ServerEnvironment Environment56 = new("environment56");
    /// <summary>
    /// Live Environment
    /// </summary>
    public static readonly ServerEnvironment Environment57 = new("environment57");
    /// <summary>
    /// Live Environment
    /// </summary>
    public static readonly ServerEnvironment Environment58 = new("environment58");
    /// <summary>
    /// Live Environment
    /// </summary>
    public static readonly ServerEnvironment Environment59 = new("environment59");
    /// <summary>
    /// Live Environment
    /// </summary>
    public static readonly ServerEnvironment Environment60 = new("environment60");
    /// <summary>
    /// Live environment for East Asia
    /// </summary>
    public static readonly ServerEnvironment Environment61 = new("environment61");
    /// <summary>
    /// Live environment for East Asia
    /// </summary>
    public static readonly ServerEnvironment Environment62 = new("environment62");
    /// <summary>
    /// Live environment for East Asia
    /// </summary>
    public static readonly ServerEnvironment Environment63 = new("environment63");
    /// <summary>
    /// Live environment for East Asia
    /// </summary>
    public static readonly ServerEnvironment Environment64 = new("environment64");
    /// <summary>
    /// Live environment for East Asia
    /// </summary>
    public static readonly ServerEnvironment Environment65 = new("environment65");
    /// <summary>
    /// Live environment for East Asia
    /// </summary>
    public static readonly ServerEnvironment Environment66 = new("environment66");
    /// <summary>
    /// Live environment for East Asia
    /// </summary>
    public static readonly ServerEnvironment Environment67 = new("environment67");
    /// <summary>
    /// Live environment for East Asia
    /// </summary>
    public static readonly ServerEnvironment Environment68 = new("environment68");
    /// <summary>
    /// Live environment for East Asia
    /// </summary>
    public static readonly ServerEnvironment Environment69 = new("environment69");
    /// <summary>
    /// Live environment for East Asia
    /// </summary>
    public static readonly ServerEnvironment Environment70 = new("environment70");
    /// <summary>
    /// Live environment for East Asia
    /// </summary>
    public static readonly ServerEnvironment Environment71 = new("environment71");
    /// <summary>
    /// Live environment for East Asia
    /// </summary>
    public static readonly ServerEnvironment Environment72 = new("environment72");
    /// <summary>
    /// Live environment for East Asia
    /// </summary>
    public static readonly ServerEnvironment Environment73 = new("environment73");
    /// <summary>
    /// Live environment for East Asia
    /// </summary>
    public static readonly ServerEnvironment Environment74 = new("environment74");
    /// <summary>
    /// Live environment for East Asia
    /// </summary>
    public static readonly ServerEnvironment Environment75 = new("environment75");
    /// <summary>
    /// Live environment for East Asia
    /// </summary>
    public static readonly ServerEnvironment Environment76 = new("environment76");
    /// <summary>
    /// Live environment for East Asia
    /// </summary>
    public static readonly ServerEnvironment Environment77 = new("environment77");
    /// <summary>
    /// Live environment for East Asia
    /// </summary>
    public static readonly ServerEnvironment Environment78 = new("environment78");
    /// <summary>
    /// Live environment for East Asia
    /// </summary>
    public static readonly ServerEnvironment Environment79 = new("environment79");
    /// <summary>
    /// Live environment for East Asia
    /// </summary>
    public static readonly ServerEnvironment Environment80 = new("environment80");
    /// <summary>
    /// Live environment for East Asia
    /// </summary>
    public static readonly ServerEnvironment Environment81 = new("environment81");
    /// <summary>
    /// Live environment for East Asia
    /// </summary>
    public static readonly ServerEnvironment Environment82 = new("environment82");
    /// <summary>
    /// Live environment for East Asia
    /// </summary>
    public static readonly ServerEnvironment Environment83 = new("environment83");
    /// <summary>
    /// Live environment for East Asia
    /// </summary>
    public static readonly ServerEnvironment Environment84 = new("environment84");
    /// <summary>
    /// Live environment for East Asia
    /// </summary>
    public static readonly ServerEnvironment Environment85 = new("environment85");
    /// <summary>
    /// Live environment for East Asia
    /// </summary>
    public static readonly ServerEnvironment Environment86 = new("environment86");
    /// <summary>
    /// Live environment for East Asia
    /// </summary>
    public static readonly ServerEnvironment Environment87 = new("environment87");
    /// <summary>
    /// Live environment for East Asia
    /// </summary>
    public static readonly ServerEnvironment Environment88 = new("environment88");
    /// <summary>
    /// Live environment for East Asia
    /// </summary>
    public static readonly ServerEnvironment Environment89 = new("environment89");
    /// <summary>
    /// Live environment for East Asia
    /// </summary>
    public static readonly ServerEnvironment Environment90 = new("environment90");
    /// <summary>
    /// Live environment for Europe
    /// </summary>
    public static readonly ServerEnvironment Environment91 = new("environment91");
    /// <summary>
    /// Live environment for Europe
    /// </summary>
    public static readonly ServerEnvironment Environment92 = new("environment92");
    /// <summary>
    /// Live environment for Europe
    /// </summary>
    public static readonly ServerEnvironment Environment93 = new("environment93");
    /// <summary>
    /// Live environment for Europe
    /// </summary>
    public static readonly ServerEnvironment Environment94 = new("environment94");
    /// <summary>
    /// Live environment for Europe
    /// </summary>
    public static readonly ServerEnvironment Environment95 = new("environment95");
    /// <summary>
    /// Live environment for Europe
    /// </summary>
    public static readonly ServerEnvironment Environment96 = new("environment96");
    /// <summary>
    /// Live environment for Europe
    /// </summary>
    public static readonly ServerEnvironment Environment97 = new("environment97");
    /// <summary>
    /// Live environment for Europe
    /// </summary>
    public static readonly ServerEnvironment Environment98 = new("environment98");
    /// <summary>
    /// Live environment for Europe
    /// </summary>
    public static readonly ServerEnvironment Environment99 = new("environment99");
    /// <summary>
    /// Live environment for Europe
    /// </summary>
    public static readonly ServerEnvironment Environment100 = new("environment100");
    /// <summary>
    /// Live environment for Europe
    /// </summary>
    public static readonly ServerEnvironment Environment101 = new("environment101");
    /// <summary>
    /// Live environment for Europe
    /// </summary>
    public static readonly ServerEnvironment Environment102 = new("environment102");
    /// <summary>
    /// Live environment for Europe
    /// </summary>
    public static readonly ServerEnvironment Environment103 = new("environment103");
    /// <summary>
    /// Live environment for Europe
    /// </summary>
    public static readonly ServerEnvironment Environment104 = new("environment104");
    /// <summary>
    /// Live environment for Europe
    /// </summary>
    public static readonly ServerEnvironment Environment105 = new("environment105");
    /// <summary>
    /// Live environment for Europe
    /// </summary>
    public static readonly ServerEnvironment Environment106 = new("environment106");
    /// <summary>
    /// Live environment for Europe
    /// </summary>
    public static readonly ServerEnvironment Environment107 = new("environment107");
    /// <summary>
    /// Live environment for Europe
    /// </summary>
    public static readonly ServerEnvironment Environment108 = new("environment108");
    /// <summary>
    /// Live environment for Europe
    /// </summary>
    public static readonly ServerEnvironment Environment109 = new("environment109");
    /// <summary>
    /// Live environment for Europe
    /// </summary>
    public static readonly ServerEnvironment Environment110 = new("environment110");
    /// <summary>
    /// Live environment for Europe
    /// </summary>
    public static readonly ServerEnvironment Environment111 = new("environment111");
    /// <summary>
    /// Live environment for Europe
    /// </summary>
    public static readonly ServerEnvironment Environment112 = new("environment112");
    /// <summary>
    /// Live environment for Europe
    /// </summary>
    public static readonly ServerEnvironment Environment113 = new("environment113");
    /// <summary>
    /// Live environment for Europe
    /// </summary>
    public static readonly ServerEnvironment Environment114 = new("environment114");
    /// <summary>
    /// Live environment for Europe
    /// </summary>
    public static readonly ServerEnvironment Environment115 = new("environment115");
    /// <summary>
    /// Live environment for Europe
    /// </summary>
    public static readonly ServerEnvironment Environment116 = new("environment116");
    /// <summary>
    /// Live environment for Europe
    /// </summary>
    public static readonly ServerEnvironment Environment117 = new("environment117");
    /// <summary>
    /// Live environment for Europe
    /// </summary>
    public static readonly ServerEnvironment Environment118 = new("environment118");
    /// <summary>
    /// Live environment for Europe
    /// </summary>
    public static readonly ServerEnvironment Environment119 = new("environment119");
    /// <summary>
    /// Live environment for Europe
    /// </summary>
    public static readonly ServerEnvironment Environment120 = new("environment120");
    /// <summary>
    /// Live environment for United States of America
    /// </summary>
    public static readonly ServerEnvironment Environment121 = new("environment121");
    /// <summary>
    /// Live environment for United States of America
    /// </summary>
    public static readonly ServerEnvironment Environment122 = new("environment122");
    /// <summary>
    /// Live environment for United States of America
    /// </summary>
    public static readonly ServerEnvironment Environment123 = new("environment123");
    /// <summary>
    /// Live environment for United States of America
    /// </summary>
    public static readonly ServerEnvironment Environment124 = new("environment124");
    /// <summary>
    /// Live environment for United States of America
    /// </summary>
    public static readonly ServerEnvironment Environment125 = new("environment125");
    /// <summary>
    /// Live environment for United States of America
    /// </summary>
    public static readonly ServerEnvironment Environment126 = new("environment126");
    /// <summary>
    /// Live environment for United States of America
    /// </summary>
    public static readonly ServerEnvironment Environment127 = new("environment127");
    /// <summary>
    /// Live environment for United States of America
    /// </summary>
    public static readonly ServerEnvironment Environment128 = new("environment128");
    /// <summary>
    /// Live environment for United States of America
    /// </summary>
    public static readonly ServerEnvironment Environment129 = new("environment129");
    /// <summary>
    /// Live environment for United States of America
    /// </summary>
    public static readonly ServerEnvironment Environment130 = new("environment130");
    /// <summary>
    /// Live environment for United States of America
    /// </summary>
    public static readonly ServerEnvironment Environment131 = new("environment131");
    /// <summary>
    /// Live environment for United States of America
    /// </summary>
    public static readonly ServerEnvironment Environment132 = new("environment132");
    /// <summary>
    /// Live environment for United States of America
    /// </summary>
    public static readonly ServerEnvironment Environment133 = new("environment133");
    /// <summary>
    /// Live environment for United States of America
    /// </summary>
    public static readonly ServerEnvironment Environment134 = new("environment134");
    /// <summary>
    /// Live environment for United States of America
    /// </summary>
    public static readonly ServerEnvironment Environment135 = new("environment135");
    /// <summary>
    /// Live environment for United States of America
    /// </summary>
    public static readonly ServerEnvironment Environment136 = new("environment136");
    /// <summary>
    /// Live environment for United States of America
    /// </summary>
    public static readonly ServerEnvironment Environment137 = new("environment137");
    /// <summary>
    /// Live environment for United States of America
    /// </summary>
    public static readonly ServerEnvironment Environment138 = new("environment138");
    /// <summary>
    /// Live environment for United States of America
    /// </summary>
    public static readonly ServerEnvironment Environment139 = new("environment139");
    /// <summary>
    /// Live environment for United States of America
    /// </summary>
    public static readonly ServerEnvironment Environment140 = new("environment140");
    /// <summary>
    /// Live environment for United States of America
    /// </summary>
    public static readonly ServerEnvironment Environment141 = new("environment141");
    /// <summary>
    /// Live environment for United States of America
    /// </summary>
    public static readonly ServerEnvironment Environment142 = new("environment142");
    /// <summary>
    /// Live environment for United States of America
    /// </summary>
    public static readonly ServerEnvironment Environment143 = new("environment143");
    /// <summary>
    /// Live environment for United States of America
    /// </summary>
    public static readonly ServerEnvironment Environment144 = new("environment144");
    /// <summary>
    /// Live environment for United States of America
    /// </summary>
    public static readonly ServerEnvironment Environment145 = new("environment145");
    /// <summary>
    /// Live environment for United States of America
    /// </summary>
    public static readonly ServerEnvironment Environment146 = new("environment146");
    /// <summary>
    /// Live environment for United States of America
    /// </summary>
    public static readonly ServerEnvironment Environment147 = new("environment147");
    /// <summary>
    /// Live environment for United States of America
    /// </summary>
    public static readonly ServerEnvironment Environment148 = new("environment148");
    /// <summary>
    /// Live environment for United States of America
    /// </summary>
    public static readonly ServerEnvironment Environment149 = new("environment149");
    /// <summary>
    /// Live environment for United States of America
    /// </summary>
    public static readonly ServerEnvironment Environment150 = new("environment150");
    /// <summary>
    /// Live environment for United States of America
    /// </summary>
    public static readonly ServerEnvironment Environment151 = new("environment151");
    /// <summary>
    /// Live environment for United States of America
    /// </summary>
    public static readonly ServerEnvironment Environment152 = new("environment152");
    /// <summary>
    /// Live environment for United States of America
    /// </summary>
    public static readonly ServerEnvironment Environment153 = new("environment153");
    /// <summary>
    /// Live environment for United States of America
    /// </summary>
    public static readonly ServerEnvironment Environment154 = new("environment154");
    /// <summary>
    /// Live environment for United States of America
    /// </summary>
    public static readonly ServerEnvironment Environment155 = new("environment155");
    /// <summary>
    /// Live environment for United States of America
    /// </summary>
    public static readonly ServerEnvironment Environment156 = new("environment156");
    /// <summary>
    /// Live environment for United States of America
    /// </summary>
    public static readonly ServerEnvironment Environment157 = new("environment157");
    /// <summary>
    /// Live environment for United States of America
    /// </summary>
    public static readonly ServerEnvironment Environment158 = new("environment158");
    /// <summary>
    /// Live environment for United States of America
    /// </summary>
    public static readonly ServerEnvironment Environment159 = new("environment159");
    /// <summary>
    /// Live environment for United States of America
    /// </summary>
    public static readonly ServerEnvironment Environment160 = new("environment160");
    /// <summary>
    /// Live environment for United States of America
    /// </summary>
    public static readonly ServerEnvironment Environment161 = new("environment161");
    /// <summary>
    /// Live environment for United States of America
    /// </summary>
    public static readonly ServerEnvironment Environment162 = new("environment162");
    /// <summary>
    /// Live environment for United States of America
    /// </summary>
    public static readonly ServerEnvironment Environment163 = new("environment163");
    /// <summary>
    /// Live environment for United States of America
    /// </summary>
    public static readonly ServerEnvironment Environment164 = new("environment164");
    /// <summary>
    /// Live environment for United States of America
    /// </summary>
    public static readonly ServerEnvironment Environment165 = new("environment165");
    /// <summary>
    /// Live environment for United States of America
    /// </summary>
    public static readonly ServerEnvironment Environment166 = new("environment166");
    /// <summary>
    /// Live environment for United States of America
    /// </summary>
    public static readonly ServerEnvironment Environment167 = new("environment167");
    /// <summary>
    /// Live environment for United States of America
    /// </summary>
    public static readonly ServerEnvironment Environment168 = new("environment168");
    /// <summary>
    /// Live environment for United States of America
    /// </summary>
    public static readonly ServerEnvironment Environment169 = new("environment169");
    /// <summary>
    /// Live environment for United States of America
    /// </summary>
    public static readonly ServerEnvironment Environment170 = new("environment170");
    /// <summary>
    /// Live environment for United States of America
    /// </summary>
    public static readonly ServerEnvironment Environment171 = new("environment171");
    /// <summary>
    /// Live environment for United States of America
    /// </summary>
    public static readonly ServerEnvironment Environment172 = new("environment172");
    /// <summary>
    /// Live environment for United States of America
    /// </summary>
    public static readonly ServerEnvironment Environment173 = new("environment173");
    /// <summary>
    /// Live environment for United States of America
    /// </summary>
    public static readonly ServerEnvironment Environment174 = new("environment174");
    /// <summary>
    /// Live environment for United States of America
    /// </summary>
    public static readonly ServerEnvironment Environment175 = new("environment175");
    /// <summary>
    /// Live environment for United States of America
    /// </summary>
    public static readonly ServerEnvironment Environment176 = new("environment176");
    /// <summary>
    /// Live environment for United States of America
    /// </summary>
    public static readonly ServerEnvironment Environment177 = new("environment177");
    /// <summary>
    /// Live environment for United States of America
    /// </summary>
    public static readonly ServerEnvironment Environment178 = new("environment178");
    /// <summary>
    /// Live environment for United States of America
    /// </summary>
    public static readonly ServerEnvironment Environment179 = new("environment179");
    /// <summary>
    /// Live environment for United States of America
    /// </summary>
    public static readonly ServerEnvironment Environment180 = new("environment180");

    private ServerEnvironment(string value) : base(value)
    {
    }

    internal T Match<T>(Func<T> onProduction,
        Func<T> onEnvironment2,
        Func<T> onEnvironment3,
        Func<T> onEnvironment4,
        Func<T> onEnvironment5,
        Func<T> onEnvironment6,
        Func<T> onEnvironment7,
        Func<T> onEnvironment8,
        Func<T> onEnvironment9,
        Func<T> onEnvironment10,
        Func<T> onEnvironment11,
        Func<T> onEnvironment12,
        Func<T> onEnvironment13,
        Func<T> onEnvironment14,
        Func<T> onEnvironment15,
        Func<T> onEnvironment16,
        Func<T> onEnvironment17,
        Func<T> onEnvironment18,
        Func<T> onEnvironment19,
        Func<T> onEnvironment20,
        Func<T> onEnvironment21,
        Func<T> onEnvironment22,
        Func<T> onEnvironment23,
        Func<T> onEnvironment24,
        Func<T> onEnvironment25,
        Func<T> onEnvironment26,
        Func<T> onEnvironment27,
        Func<T> onEnvironment28,
        Func<T> onEnvironment29,
        Func<T> onEnvironment30,
        Func<T> onEnvironment31,
        Func<T> onEnvironment32,
        Func<T> onEnvironment33,
        Func<T> onEnvironment34,
        Func<T> onEnvironment35,
        Func<T> onEnvironment36,
        Func<T> onEnvironment37,
        Func<T> onEnvironment38,
        Func<T> onEnvironment39,
        Func<T> onEnvironment40,
        Func<T> onEnvironment41,
        Func<T> onEnvironment42,
        Func<T> onEnvironment43,
        Func<T> onEnvironment44,
        Func<T> onEnvironment45,
        Func<T> onEnvironment46,
        Func<T> onEnvironment47,
        Func<T> onEnvironment48,
        Func<T> onEnvironment49,
        Func<T> onEnvironment50,
        Func<T> onEnvironment51,
        Func<T> onEnvironment52,
        Func<T> onEnvironment53,
        Func<T> onEnvironment54,
        Func<T> onEnvironment55,
        Func<T> onEnvironment56,
        Func<T> onEnvironment57,
        Func<T> onEnvironment58,
        Func<T> onEnvironment59,
        Func<T> onEnvironment60,
        Func<T> onEnvironment61,
        Func<T> onEnvironment62,
        Func<T> onEnvironment63,
        Func<T> onEnvironment64,
        Func<T> onEnvironment65,
        Func<T> onEnvironment66,
        Func<T> onEnvironment67,
        Func<T> onEnvironment68,
        Func<T> onEnvironment69,
        Func<T> onEnvironment70,
        Func<T> onEnvironment71,
        Func<T> onEnvironment72,
        Func<T> onEnvironment73,
        Func<T> onEnvironment74,
        Func<T> onEnvironment75,
        Func<T> onEnvironment76,
        Func<T> onEnvironment77,
        Func<T> onEnvironment78,
        Func<T> onEnvironment79,
        Func<T> onEnvironment80,
        Func<T> onEnvironment81,
        Func<T> onEnvironment82,
        Func<T> onEnvironment83,
        Func<T> onEnvironment84,
        Func<T> onEnvironment85,
        Func<T> onEnvironment86,
        Func<T> onEnvironment87,
        Func<T> onEnvironment88,
        Func<T> onEnvironment89,
        Func<T> onEnvironment90,
        Func<T> onEnvironment91,
        Func<T> onEnvironment92,
        Func<T> onEnvironment93,
        Func<T> onEnvironment94,
        Func<T> onEnvironment95,
        Func<T> onEnvironment96,
        Func<T> onEnvironment97,
        Func<T> onEnvironment98,
        Func<T> onEnvironment99,
        Func<T> onEnvironment100,
        Func<T> onEnvironment101,
        Func<T> onEnvironment102,
        Func<T> onEnvironment103,
        Func<T> onEnvironment104,
        Func<T> onEnvironment105,
        Func<T> onEnvironment106,
        Func<T> onEnvironment107,
        Func<T> onEnvironment108,
        Func<T> onEnvironment109,
        Func<T> onEnvironment110,
        Func<T> onEnvironment111,
        Func<T> onEnvironment112,
        Func<T> onEnvironment113,
        Func<T> onEnvironment114,
        Func<T> onEnvironment115,
        Func<T> onEnvironment116,
        Func<T> onEnvironment117,
        Func<T> onEnvironment118,
        Func<T> onEnvironment119,
        Func<T> onEnvironment120,
        Func<T> onEnvironment121,
        Func<T> onEnvironment122,
        Func<T> onEnvironment123,
        Func<T> onEnvironment124,
        Func<T> onEnvironment125,
        Func<T> onEnvironment126,
        Func<T> onEnvironment127,
        Func<T> onEnvironment128,
        Func<T> onEnvironment129,
        Func<T> onEnvironment130,
        Func<T> onEnvironment131,
        Func<T> onEnvironment132,
        Func<T> onEnvironment133,
        Func<T> onEnvironment134,
        Func<T> onEnvironment135,
        Func<T> onEnvironment136,
        Func<T> onEnvironment137,
        Func<T> onEnvironment138,
        Func<T> onEnvironment139,
        Func<T> onEnvironment140,
        Func<T> onEnvironment141,
        Func<T> onEnvironment142,
        Func<T> onEnvironment143,
        Func<T> onEnvironment144,
        Func<T> onEnvironment145,
        Func<T> onEnvironment146,
        Func<T> onEnvironment147,
        Func<T> onEnvironment148,
        Func<T> onEnvironment149,
        Func<T> onEnvironment150,
        Func<T> onEnvironment151,
        Func<T> onEnvironment152,
        Func<T> onEnvironment153,
        Func<T> onEnvironment154,
        Func<T> onEnvironment155,
        Func<T> onEnvironment156,
        Func<T> onEnvironment157,
        Func<T> onEnvironment158,
        Func<T> onEnvironment159,
        Func<T> onEnvironment160,
        Func<T> onEnvironment161,
        Func<T> onEnvironment162,
        Func<T> onEnvironment163,
        Func<T> onEnvironment164,
        Func<T> onEnvironment165,
        Func<T> onEnvironment166,
        Func<T> onEnvironment167,
        Func<T> onEnvironment168,
        Func<T> onEnvironment169,
        Func<T> onEnvironment170,
        Func<T> onEnvironment171,
        Func<T> onEnvironment172,
        Func<T> onEnvironment173,
        Func<T> onEnvironment174,
        Func<T> onEnvironment175,
        Func<T> onEnvironment176,
        Func<T> onEnvironment177,
        Func<T> onEnvironment178,
        Func<T> onEnvironment179,
        Func<T> onEnvironment180) =>
        this switch
        {
            _ when this == Production => onProduction(),
            _ when this == Environment2 => onEnvironment2(),
            _ when this == Environment3 => onEnvironment3(),
            _ when this == Environment4 => onEnvironment4(),
            _ when this == Environment5 => onEnvironment5(),
            _ when this == Environment6 => onEnvironment6(),
            _ when this == Environment7 => onEnvironment7(),
            _ when this == Environment8 => onEnvironment8(),
            _ when this == Environment9 => onEnvironment9(),
            _ when this == Environment10 => onEnvironment10(),
            _ when this == Environment11 => onEnvironment11(),
            _ when this == Environment12 => onEnvironment12(),
            _ when this == Environment13 => onEnvironment13(),
            _ when this == Environment14 => onEnvironment14(),
            _ when this == Environment15 => onEnvironment15(),
            _ when this == Environment16 => onEnvironment16(),
            _ when this == Environment17 => onEnvironment17(),
            _ when this == Environment18 => onEnvironment18(),
            _ when this == Environment19 => onEnvironment19(),
            _ when this == Environment20 => onEnvironment20(),
            _ when this == Environment21 => onEnvironment21(),
            _ when this == Environment22 => onEnvironment22(),
            _ when this == Environment23 => onEnvironment23(),
            _ when this == Environment24 => onEnvironment24(),
            _ when this == Environment25 => onEnvironment25(),
            _ when this == Environment26 => onEnvironment26(),
            _ when this == Environment27 => onEnvironment27(),
            _ when this == Environment28 => onEnvironment28(),
            _ when this == Environment29 => onEnvironment29(),
            _ when this == Environment30 => onEnvironment30(),
            _ when this == Environment31 => onEnvironment31(),
            _ when this == Environment32 => onEnvironment32(),
            _ when this == Environment33 => onEnvironment33(),
            _ when this == Environment34 => onEnvironment34(),
            _ when this == Environment35 => onEnvironment35(),
            _ when this == Environment36 => onEnvironment36(),
            _ when this == Environment37 => onEnvironment37(),
            _ when this == Environment38 => onEnvironment38(),
            _ when this == Environment39 => onEnvironment39(),
            _ when this == Environment40 => onEnvironment40(),
            _ when this == Environment41 => onEnvironment41(),
            _ when this == Environment42 => onEnvironment42(),
            _ when this == Environment43 => onEnvironment43(),
            _ when this == Environment44 => onEnvironment44(),
            _ when this == Environment45 => onEnvironment45(),
            _ when this == Environment46 => onEnvironment46(),
            _ when this == Environment47 => onEnvironment47(),
            _ when this == Environment48 => onEnvironment48(),
            _ when this == Environment49 => onEnvironment49(),
            _ when this == Environment50 => onEnvironment50(),
            _ when this == Environment51 => onEnvironment51(),
            _ when this == Environment52 => onEnvironment52(),
            _ when this == Environment53 => onEnvironment53(),
            _ when this == Environment54 => onEnvironment54(),
            _ when this == Environment55 => onEnvironment55(),
            _ when this == Environment56 => onEnvironment56(),
            _ when this == Environment57 => onEnvironment57(),
            _ when this == Environment58 => onEnvironment58(),
            _ when this == Environment59 => onEnvironment59(),
            _ when this == Environment60 => onEnvironment60(),
            _ when this == Environment61 => onEnvironment61(),
            _ when this == Environment62 => onEnvironment62(),
            _ when this == Environment63 => onEnvironment63(),
            _ when this == Environment64 => onEnvironment64(),
            _ when this == Environment65 => onEnvironment65(),
            _ when this == Environment66 => onEnvironment66(),
            _ when this == Environment67 => onEnvironment67(),
            _ when this == Environment68 => onEnvironment68(),
            _ when this == Environment69 => onEnvironment69(),
            _ when this == Environment70 => onEnvironment70(),
            _ when this == Environment71 => onEnvironment71(),
            _ when this == Environment72 => onEnvironment72(),
            _ when this == Environment73 => onEnvironment73(),
            _ when this == Environment74 => onEnvironment74(),
            _ when this == Environment75 => onEnvironment75(),
            _ when this == Environment76 => onEnvironment76(),
            _ when this == Environment77 => onEnvironment77(),
            _ when this == Environment78 => onEnvironment78(),
            _ when this == Environment79 => onEnvironment79(),
            _ when this == Environment80 => onEnvironment80(),
            _ when this == Environment81 => onEnvironment81(),
            _ when this == Environment82 => onEnvironment82(),
            _ when this == Environment83 => onEnvironment83(),
            _ when this == Environment84 => onEnvironment84(),
            _ when this == Environment85 => onEnvironment85(),
            _ when this == Environment86 => onEnvironment86(),
            _ when this == Environment87 => onEnvironment87(),
            _ when this == Environment88 => onEnvironment88(),
            _ when this == Environment89 => onEnvironment89(),
            _ when this == Environment90 => onEnvironment90(),
            _ when this == Environment91 => onEnvironment91(),
            _ when this == Environment92 => onEnvironment92(),
            _ when this == Environment93 => onEnvironment93(),
            _ when this == Environment94 => onEnvironment94(),
            _ when this == Environment95 => onEnvironment95(),
            _ when this == Environment96 => onEnvironment96(),
            _ when this == Environment97 => onEnvironment97(),
            _ when this == Environment98 => onEnvironment98(),
            _ when this == Environment99 => onEnvironment99(),
            _ when this == Environment100 => onEnvironment100(),
            _ when this == Environment101 => onEnvironment101(),
            _ when this == Environment102 => onEnvironment102(),
            _ when this == Environment103 => onEnvironment103(),
            _ when this == Environment104 => onEnvironment104(),
            _ when this == Environment105 => onEnvironment105(),
            _ when this == Environment106 => onEnvironment106(),
            _ when this == Environment107 => onEnvironment107(),
            _ when this == Environment108 => onEnvironment108(),
            _ when this == Environment109 => onEnvironment109(),
            _ when this == Environment110 => onEnvironment110(),
            _ when this == Environment111 => onEnvironment111(),
            _ when this == Environment112 => onEnvironment112(),
            _ when this == Environment113 => onEnvironment113(),
            _ when this == Environment114 => onEnvironment114(),
            _ when this == Environment115 => onEnvironment115(),
            _ when this == Environment116 => onEnvironment116(),
            _ when this == Environment117 => onEnvironment117(),
            _ when this == Environment118 => onEnvironment118(),
            _ when this == Environment119 => onEnvironment119(),
            _ when this == Environment120 => onEnvironment120(),
            _ when this == Environment121 => onEnvironment121(),
            _ when this == Environment122 => onEnvironment122(),
            _ when this == Environment123 => onEnvironment123(),
            _ when this == Environment124 => onEnvironment124(),
            _ when this == Environment125 => onEnvironment125(),
            _ when this == Environment126 => onEnvironment126(),
            _ when this == Environment127 => onEnvironment127(),
            _ when this == Environment128 => onEnvironment128(),
            _ when this == Environment129 => onEnvironment129(),
            _ when this == Environment130 => onEnvironment130(),
            _ when this == Environment131 => onEnvironment131(),
            _ when this == Environment132 => onEnvironment132(),
            _ when this == Environment133 => onEnvironment133(),
            _ when this == Environment134 => onEnvironment134(),
            _ when this == Environment135 => onEnvironment135(),
            _ when this == Environment136 => onEnvironment136(),
            _ when this == Environment137 => onEnvironment137(),
            _ when this == Environment138 => onEnvironment138(),
            _ when this == Environment139 => onEnvironment139(),
            _ when this == Environment140 => onEnvironment140(),
            _ when this == Environment141 => onEnvironment141(),
            _ when this == Environment142 => onEnvironment142(),
            _ when this == Environment143 => onEnvironment143(),
            _ when this == Environment144 => onEnvironment144(),
            _ when this == Environment145 => onEnvironment145(),
            _ when this == Environment146 => onEnvironment146(),
            _ when this == Environment147 => onEnvironment147(),
            _ when this == Environment148 => onEnvironment148(),
            _ when this == Environment149 => onEnvironment149(),
            _ when this == Environment150 => onEnvironment150(),
            _ when this == Environment151 => onEnvironment151(),
            _ when this == Environment152 => onEnvironment152(),
            _ when this == Environment153 => onEnvironment153(),
            _ when this == Environment154 => onEnvironment154(),
            _ when this == Environment155 => onEnvironment155(),
            _ when this == Environment156 => onEnvironment156(),
            _ when this == Environment157 => onEnvironment157(),
            _ when this == Environment158 => onEnvironment158(),
            _ when this == Environment159 => onEnvironment159(),
            _ when this == Environment160 => onEnvironment160(),
            _ when this == Environment161 => onEnvironment161(),
            _ when this == Environment162 => onEnvironment162(),
            _ when this == Environment163 => onEnvironment163(),
            _ when this == Environment164 => onEnvironment164(),
            _ when this == Environment165 => onEnvironment165(),
            _ when this == Environment166 => onEnvironment166(),
            _ when this == Environment167 => onEnvironment167(),
            _ when this == Environment168 => onEnvironment168(),
            _ when this == Environment169 => onEnvironment169(),
            _ when this == Environment170 => onEnvironment170(),
            _ when this == Environment171 => onEnvironment171(),
            _ when this == Environment172 => onEnvironment172(),
            _ when this == Environment173 => onEnvironment173(),
            _ when this == Environment174 => onEnvironment174(),
            _ when this == Environment175 => onEnvironment175(),
            _ when this == Environment176 => onEnvironment176(),
            _ when this == Environment177 => onEnvironment177(),
            _ when this == Environment178 => onEnvironment178(),
            _ when this == Environment179 => onEnvironment179(),
            _ when this == Environment180 => onEnvironment180(),
            _ => throw new ArgumentOutOfRangeException(nameof(ServerEnvironment),
                this,
                $"Unknown {nameof(ServerEnvironment)} value.")
        };

    public static ServerEnvironment Default() => Production;
}
