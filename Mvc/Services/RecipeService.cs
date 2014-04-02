using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Data;
using RadarcOnline.App.DTO;
using System.Configuration;

namespace RadarcOnline.App.Services
{
	public class RecipeService : RecipeServiceBase, IRecipeService
    {
		// Put your custom code here
	}

    public abstract class RecipeServiceBase
	{
	       
		protected List<RecipeDTO> RecipeDTOCollection	= new List<RecipeDTO>{
																	new RecipeDTO {
                                                                        Continent	= "Continent806581029",	
                                                                        Name	= "Name1547416843",	
                                                                        Instructions	= "Instructions2141639685",	
                                                                        Ingredients	= "Ingredients1451985091",	
                                                                        Image	= "Image356645859",	
                                                                        Vegan	= bool.Parse("Vegan1606091951"),	
                                                                        Calories	= int.Parse("Calories673003643"),	
                                                                        PreparationTime	= int.Parse("PreparationTime1054283479"),	
																	}, 	
																	new RecipeDTO {
                                                                        Continent	= "Continent102800910",	
                                                                        Name	= "Name1325529759",	
                                                                        Instructions	= "Instructions255125919",	
                                                                        Ingredients	= "Ingredients186296805",	
                                                                        Image	= "Image1091771089",	
                                                                        Vegan	= bool.Parse("Vegan487767241"),	
                                                                        Calories	= int.Parse("Calories385517865"),	
                                                                        PreparationTime	= int.Parse("PreparationTime973371951"),	
																	}, 	
																	new RecipeDTO {
                                                                        Continent	= "Continent1941204269",	
                                                                        Name	= "Name618507698",	
                                                                        Instructions	= "Instructions270368713",	
                                                                        Ingredients	= "Ingredients1728804649",	
                                                                        Image	= "Image670749899",	
                                                                        Vegan	= bool.Parse("Vegan1398473501"),	
                                                                        Calories	= int.Parse("Calories523229559"),	
                                                                        PreparationTime	= int.Parse("PreparationTime1068002425"),	
																	}, 	
																	new RecipeDTO {
                                                                        Continent	= "Continent1340325721",	
                                                                        Name	= "Name910631429",	
                                                                        Instructions	= "Instructions153847796",	
                                                                        Ingredients	= "Ingredients373709144",	
                                                                        Image	= "Image1011624754",	
                                                                        Vegan	= bool.Parse("Vegan1499697066"),	
                                                                        Calories	= int.Parse("Calories1147818616"),	
                                                                        PreparationTime	= int.Parse("PreparationTime1328491381"),	
																	}, 	
																	new RecipeDTO {
                                                                        Continent	= "Continent131995141",	
                                                                        Name	= "Name2022216502",	
                                                                        Instructions	= "Instructions1309809338",	
                                                                        Ingredients	= "Ingredients270933479",	
                                                                        Image	= "Image405321496",	
                                                                        Vegan	= bool.Parse("Vegan1034993909"),	
                                                                        Calories	= int.Parse("Calories1346607082"),	
                                                                        PreparationTime	= int.Parse("PreparationTime900508301"),	
																	}, 	
																	new RecipeDTO {
                                                                        Continent	= "Continent1090867009",	
                                                                        Name	= "Name412537571",	
                                                                        Instructions	= "Instructions1338672587",	
                                                                        Ingredients	= "Ingredients2026477561",	
                                                                        Image	= "Image636996604",	
                                                                        Vegan	= bool.Parse("Vegan1592970107"),	
                                                                        Calories	= int.Parse("Calories1040085287"),	
                                                                        PreparationTime	= int.Parse("PreparationTime847528539"),	
																	}, 	
																	new RecipeDTO {
                                                                        Continent	= "Continent2144936140",	
                                                                        Name	= "Name2098319458",	
                                                                        Instructions	= "Instructions1205945408",	
                                                                        Ingredients	= "Ingredients856023136",	
                                                                        Image	= "Image1279427387",	
                                                                        Vegan	= bool.Parse("Vegan2114581020"),	
                                                                        Calories	= int.Parse("Calories1137175147"),	
                                                                        PreparationTime	= int.Parse("PreparationTime1555591175"),	
																	}, 	
																	new RecipeDTO {
                                                                        Continent	= "Continent1024187284",	
                                                                        Name	= "Name1073637260",	
                                                                        Instructions	= "Instructions111659370",	
                                                                        Ingredients	= "Ingredients1593498077",	
                                                                        Image	= "Image1452244155",	
                                                                        Vegan	= bool.Parse("Vegan299294499"),	
                                                                        Calories	= int.Parse("Calories42658725"),	
                                                                        PreparationTime	= int.Parse("PreparationTime750587491"),	
																	}, 	
																	new RecipeDTO {
                                                                        Continent	= "Continent177711143",	
                                                                        Name	= "Name1074118185",	
                                                                        Instructions	= "Instructions54301664",	
                                                                        Ingredients	= "Ingredients1217038234",	
                                                                        Image	= "Image1325441550",	
                                                                        Vegan	= bool.Parse("Vegan114584386"),	
                                                                        Calories	= int.Parse("Calories568050455"),	
                                                                        PreparationTime	= int.Parse("PreparationTime906210360"),	
																	}, 	
																	new RecipeDTO {
                                                                        Continent	= "Continent1419384263",	
                                                                        Name	= "Name1517344059",	
                                                                        Instructions	= "Instructions637937640",	
                                                                        Ingredients	= "Ingredients258212328",	
                                                                        Image	= "Image59800914",	
                                                                        Vegan	= bool.Parse("Vegan644235645"),	
                                                                        Calories	= int.Parse("Calories431005821"),	
                                                                        PreparationTime	= int.Parse("PreparationTime1894839261"),	
																	}, 	
																	new RecipeDTO {
                                                                        Continent	= "Continent2018029789",	
                                                                        Name	= "Name1453802904",	
                                                                        Instructions	= "Instructions376256651",	
                                                                        Ingredients	= "Ingredients1060788943",	
                                                                        Image	= "Image293751658",	
                                                                        Vegan	= bool.Parse("Vegan291795480"),	
                                                                        Calories	= int.Parse("Calories49063994"),	
                                                                        PreparationTime	= int.Parse("PreparationTime164897768"),	
																	}, 	
																	new RecipeDTO {
                                                                        Continent	= "Continent885041355",	
                                                                        Name	= "Name1901701810",	
                                                                        Instructions	= "Instructions1394229842",	
                                                                        Ingredients	= "Ingredients1479167883",	
                                                                        Image	= "Image923334539",	
                                                                        Vegan	= bool.Parse("Vegan1900592652"),	
                                                                        Calories	= int.Parse("Calories1595747793"),	
                                                                        PreparationTime	= int.Parse("PreparationTime791572510"),	
																	}, 	
																	new RecipeDTO {
                                                                        Continent	= "Continent369878846",	
                                                                        Name	= "Name588085096",	
                                                                        Instructions	= "Instructions1848766418",	
                                                                        Ingredients	= "Ingredients1710362066",	
                                                                        Image	= "Image1538668443",	
                                                                        Vegan	= bool.Parse("Vegan1970530700"),	
                                                                        Calories	= int.Parse("Calories1669570636"),	
                                                                        PreparationTime	= int.Parse("PreparationTime2030351754"),	
																	}, 	
																	new RecipeDTO {
                                                                        Continent	= "Continent1530269003",	
                                                                        Name	= "Name299735048",	
                                                                        Instructions	= "Instructions1584122520",	
                                                                        Ingredients	= "Ingredients1909566975",	
                                                                        Image	= "Image1476643380",	
                                                                        Vegan	= bool.Parse("Vegan878962819"),	
                                                                        Calories	= int.Parse("Calories1495790261"),	
                                                                        PreparationTime	= int.Parse("PreparationTime379951639"),	
																	}, 	
																	new RecipeDTO {
                                                                        Continent	= "Continent642631439",	
                                                                        Name	= "Name364303756",	
                                                                        Instructions	= "Instructions1722951935",	
                                                                        Ingredients	= "Ingredients2145924898",	
                                                                        Image	= "Image2070521495",	
                                                                        Vegan	= bool.Parse("Vegan1129353429"),	
                                                                        Calories	= int.Parse("Calories456835833"),	
                                                                        PreparationTime	= int.Parse("PreparationTime2033399310"),	
																	}, 	
																	new RecipeDTO {
                                                                        Continent	= "Continent1025054191",	
                                                                        Name	= "Name2036887543",	
                                                                        Instructions	= "Instructions331996879",	
                                                                        Ingredients	= "Ingredients1571223387",	
                                                                        Image	= "Image867838191",	
                                                                        Vegan	= bool.Parse("Vegan1236366219"),	
                                                                        Calories	= int.Parse("Calories2130359468"),	
                                                                        PreparationTime	= int.Parse("PreparationTime1666275258"),	
																	}, 	
																	new RecipeDTO {
                                                                        Continent	= "Continent2069079913",	
                                                                        Name	= "Name1993848777",	
                                                                        Instructions	= "Instructions2035817129",	
                                                                        Ingredients	= "Ingredients1619199465",	
                                                                        Image	= "Image942952874",	
                                                                        Vegan	= bool.Parse("Vegan868127402"),	
                                                                        Calories	= int.Parse("Calories356170818"),	
                                                                        PreparationTime	= int.Parse("PreparationTime47499089"),	
																	}, 	
																	new RecipeDTO {
                                                                        Continent	= "Continent1931715915",	
                                                                        Name	= "Name493388544",	
                                                                        Instructions	= "Instructions1678003587",	
                                                                        Ingredients	= "Ingredients2141500257",	
                                                                        Image	= "Image855156607",	
                                                                        Vegan	= bool.Parse("Vegan286980666"),	
                                                                        Calories	= int.Parse("Calories835738035"),	
                                                                        PreparationTime	= int.Parse("PreparationTime6078536"),	
																	}, 	
																	new RecipeDTO {
                                                                        Continent	= "Continent405911549",	
                                                                        Name	= "Name1014278203",	
                                                                        Instructions	= "Instructions836536444",	
                                                                        Ingredients	= "Ingredients559030783",	
                                                                        Image	= "Image177640717",	
                                                                        Vegan	= bool.Parse("Vegan1597306542"),	
                                                                        Calories	= int.Parse("Calories868534662"),	
                                                                        PreparationTime	= int.Parse("PreparationTime1388009064"),	
																	}, 	
																	new RecipeDTO {
                                                                        Continent	= "Continent131249263",	
                                                                        Name	= "Name1962850755",	
                                                                        Instructions	= "Instructions685307875",	
                                                                        Ingredients	= "Ingredients1649264547",	
                                                                        Image	= "Image1638533821",	
                                                                        Vegan	= bool.Parse("Vegan98347249"),	
                                                                        Calories	= int.Parse("Calories1162513563"),	
                                                                        PreparationTime	= int.Parse("PreparationTime293902784"),	
																	}, 	
																	new RecipeDTO {
                                                                        Continent	= "Continent316859227",	
                                                                        Name	= "Name2065330909",	
                                                                        Instructions	= "Instructions1987970709",	
                                                                        Ingredients	= "Ingredients1630278250",	
                                                                        Image	= "Image990629337",	
                                                                        Vegan	= bool.Parse("Vegan2024074443"),	
                                                                        Calories	= int.Parse("Calories1584482412"),	
                                                                        PreparationTime	= int.Parse("PreparationTime1921987684"),	
																	}, 	
																	new RecipeDTO {
                                                                        Continent	= "Continent8132938",	
                                                                        Name	= "Name1675452846",	
                                                                        Instructions	= "Instructions214208983",	
                                                                        Ingredients	= "Ingredients1577132951",	
                                                                        Image	= "Image1598833489",	
                                                                        Vegan	= bool.Parse("Vegan462819223"),	
                                                                        Calories	= int.Parse("Calories1178242703"),	
                                                                        PreparationTime	= int.Parse("PreparationTime738073525"),	
																	}, 	
																	new RecipeDTO {
                                                                        Continent	= "Continent1201149508",	
                                                                        Name	= "Name325918343",	
                                                                        Instructions	= "Instructions1165311838",	
                                                                        Ingredients	= "Ingredients2001043635",	
                                                                        Image	= "Image399829775",	
                                                                        Vegan	= bool.Parse("Vegan1571328685"),	
                                                                        Calories	= int.Parse("Calories1488634541"),	
                                                                        PreparationTime	= int.Parse("PreparationTime471773371"),	
																	}, 	
																	new RecipeDTO {
                                                                        Continent	= "Continent1125314115",	
                                                                        Name	= "Name647808065",	
                                                                        Instructions	= "Instructions1487950202",	
                                                                        Ingredients	= "Ingredients1127585766",	
                                                                        Image	= "Image182819527",	
                                                                        Vegan	= bool.Parse("Vegan854389918"),	
                                                                        Calories	= int.Parse("Calories556448915"),	
                                                                        PreparationTime	= int.Parse("PreparationTime1833368666"),	
																	}, 	
																	new RecipeDTO {
                                                                        Continent	= "Continent1478358628",	
                                                                        Name	= "Name1384100803",	
                                                                        Instructions	= "Instructions1824641030",	
                                                                        Ingredients	= "Ingredients937309345",	
                                                                        Image	= "Image446493604",	
                                                                        Vegan	= bool.Parse("Vegan1352943432"),	
                                                                        Calories	= int.Parse("Calories1162932846"),	
                                                                        PreparationTime	= int.Parse("PreparationTime529320753"),	
																	}, 	
																	new RecipeDTO {
                                                                        Continent	= "Continent1619420501",	
                                                                        Name	= "Name1158803950",	
                                                                        Instructions	= "Instructions1902121759",	
                                                                        Ingredients	= "Ingredients1617901658",	
                                                                        Image	= "Image441990592",	
                                                                        Vegan	= bool.Parse("Vegan1770137517"),	
                                                                        Calories	= int.Parse("Calories735137776"),	
                                                                        PreparationTime	= int.Parse("PreparationTime540494936"),	
																	}, 	
																	new RecipeDTO {
                                                                        Continent	= "Continent754663879",	
                                                                        Name	= "Name746480480",	
                                                                        Instructions	= "Instructions1316699118",	
                                                                        Ingredients	= "Ingredients504794844",	
                                                                        Image	= "Image378529319",	
                                                                        Vegan	= bool.Parse("Vegan2066578454"),	
                                                                        Calories	= int.Parse("Calories1698438830"),	
                                                                        PreparationTime	= int.Parse("PreparationTime1039988333"),	
																	}, 	
																	new RecipeDTO {
                                                                        Continent	= "Continent652834213",	
                                                                        Name	= "Name342255700",	
                                                                        Instructions	= "Instructions1399737514",	
                                                                        Ingredients	= "Ingredients1419677597",	
                                                                        Image	= "Image768881808",	
                                                                        Vegan	= bool.Parse("Vegan2008428655"),	
                                                                        Calories	= int.Parse("Calories857796849"),	
                                                                        PreparationTime	= int.Parse("PreparationTime1931170989"),	
																	}, 	
																	new RecipeDTO {
                                                                        Continent	= "Continent14519641",	
                                                                        Name	= "Name1218230610",	
                                                                        Instructions	= "Instructions1129075143",	
                                                                        Ingredients	= "Ingredients1701156987",	
                                                                        Image	= "Image439225433",	
                                                                        Vegan	= bool.Parse("Vegan1447211617"),	
                                                                        Calories	= int.Parse("Calories809827908"),	
                                                                        PreparationTime	= int.Parse("PreparationTime407400487"),	
																	}, 	
																	new RecipeDTO {
                                                                        Continent	= "Continent2005821949",	
                                                                        Name	= "Name1779924116",	
                                                                        Instructions	= "Instructions368477282",	
                                                                        Ingredients	= "Ingredients771011156",	
                                                                        Image	= "Image1277733860",	
                                                                        Vegan	= bool.Parse("Vegan1280077503"),	
                                                                        Calories	= int.Parse("Calories702639902"),	
                                                                        PreparationTime	= int.Parse("PreparationTime483920279"),	
																	}, 	
																	new RecipeDTO {
                                                                        Continent	= "Continent1843171100",	
                                                                        Name	= "Name1464805910",	
                                                                        Instructions	= "Instructions1697122226",	
                                                                        Ingredients	= "Ingredients1708269568",	
                                                                        Image	= "Image1519406124",	
                                                                        Vegan	= bool.Parse("Vegan354943364"),	
                                                                        Calories	= int.Parse("Calories218971106"),	
                                                                        PreparationTime	= int.Parse("PreparationTime311081185"),	
																	}, 	
																	new RecipeDTO {
                                                                        Continent	= "Continent900136824",	
                                                                        Name	= "Name1464537173",	
                                                                        Instructions	= "Instructions543871594",	
                                                                        Ingredients	= "Ingredients1867805472",	
                                                                        Image	= "Image1472578794",	
                                                                        Vegan	= bool.Parse("Vegan1036153410"),	
                                                                        Calories	= int.Parse("Calories764720310"),	
                                                                        PreparationTime	= int.Parse("PreparationTime1758475493"),	
																	}, 	
																	new RecipeDTO {
                                                                        Continent	= "Continent301007101",	
                                                                        Name	= "Name2118434417",	
                                                                        Instructions	= "Instructions1603382017",	
                                                                        Ingredients	= "Ingredients1371243629",	
                                                                        Image	= "Image641062374",	
                                                                        Vegan	= bool.Parse("Vegan1181464436"),	
                                                                        Calories	= int.Parse("Calories101269503"),	
                                                                        PreparationTime	= int.Parse("PreparationTime1454935909"),	
																	}, 	
																	new RecipeDTO {
                                                                        Continent	= "Continent2084136219",	
                                                                        Name	= "Name909298631",	
                                                                        Instructions	= "Instructions646456542",	
                                                                        Ingredients	= "Ingredients746088850",	
                                                                        Image	= "Image1698101172",	
                                                                        Vegan	= bool.Parse("Vegan927427674"),	
                                                                        Calories	= int.Parse("Calories1909738120"),	
                                                                        PreparationTime	= int.Parse("PreparationTime1520240357"),	
																	}, 	
																	new RecipeDTO {
                                                                        Continent	= "Continent1787099445",	
                                                                        Name	= "Name915817235",	
                                                                        Instructions	= "Instructions1723990144",	
                                                                        Ingredients	= "Ingredients1451559545",	
                                                                        Image	= "Image311306429",	
                                                                        Vegan	= bool.Parse("Vegan1297010928"),	
                                                                        Calories	= int.Parse("Calories411764865"),	
                                                                        PreparationTime	= int.Parse("PreparationTime1807059924"),	
																	}, 	
																	new RecipeDTO {
                                                                        Continent	= "Continent999259504",	
                                                                        Name	= "Name817993958",	
                                                                        Instructions	= "Instructions801020163",	
                                                                        Ingredients	= "Ingredients1122171907",	
                                                                        Image	= "Image903340023",	
                                                                        Vegan	= bool.Parse("Vegan1089506083"),	
                                                                        Calories	= int.Parse("Calories1082305340"),	
                                                                        PreparationTime	= int.Parse("PreparationTime969668539"),	
																	}, 	
																	new RecipeDTO {
                                                                        Continent	= "Continent1015203806",	
                                                                        Name	= "Name757485436",	
                                                                        Instructions	= "Instructions470004055",	
                                                                        Ingredients	= "Ingredients1306783090",	
                                                                        Image	= "Image1824179133",	
                                                                        Vegan	= bool.Parse("Vegan1478879920"),	
                                                                        Calories	= int.Parse("Calories1990341552"),	
                                                                        PreparationTime	= int.Parse("PreparationTime661706664"),	
																	}, 	
																	new RecipeDTO {
                                                                        Continent	= "Continent1363536407",	
                                                                        Name	= "Name242186317",	
                                                                        Instructions	= "Instructions1771616996",	
                                                                        Ingredients	= "Ingredients610107493",	
                                                                        Image	= "Image1855970469",	
                                                                        Vegan	= bool.Parse("Vegan1620365903"),	
                                                                        Calories	= int.Parse("Calories760463660"),	
                                                                        PreparationTime	= int.Parse("PreparationTime2120192797"),	
																	}, 	
																	new RecipeDTO {
                                                                        Continent	= "Continent1702282700",	
                                                                        Name	= "Name1171114884",	
                                                                        Instructions	= "Instructions80706027",	
                                                                        Ingredients	= "Ingredients556761559",	
                                                                        Image	= "Image1459646913",	
                                                                        Vegan	= bool.Parse("Vegan1460644412"),	
                                                                        Calories	= int.Parse("Calories1447169064"),	
                                                                        PreparationTime	= int.Parse("PreparationTime1151479820"),	
																	}, 	
																	new RecipeDTO {
                                                                        Continent	= "Continent1706669552",	
                                                                        Name	= "Name1943805740",	
                                                                        Instructions	= "Instructions371984125",	
                                                                        Ingredients	= "Ingredients1970552063",	
                                                                        Image	= "Image380444273",	
                                                                        Vegan	= bool.Parse("Vegan1126581243"),	
                                                                        Calories	= int.Parse("Calories551595886"),	
                                                                        PreparationTime	= int.Parse("PreparationTime994630136"),	
																	}, 	
																	new RecipeDTO {
                                                                        Continent	= "Continent1974476938",	
                                                                        Name	= "Name1824271650",	
                                                                        Instructions	= "Instructions1878368691",	
                                                                        Ingredients	= "Ingredients940615736",	
                                                                        Image	= "Image457423619",	
                                                                        Vegan	= bool.Parse("Vegan602955030"),	
                                                                        Calories	= int.Parse("Calories1843544871"),	
                                                                        PreparationTime	= int.Parse("PreparationTime308219525"),	
																	}, 	
																	new RecipeDTO {
                                                                        Continent	= "Continent1072959330",	
                                                                        Name	= "Name1062283480",	
                                                                        Instructions	= "Instructions88023138",	
                                                                        Ingredients	= "Ingredients69120112",	
                                                                        Image	= "Image1672877579",	
                                                                        Vegan	= bool.Parse("Vegan1949141019"),	
                                                                        Calories	= int.Parse("Calories2098573102"),	
                                                                        PreparationTime	= int.Parse("PreparationTime1526377248"),	
																	}, 	
																	new RecipeDTO {
                                                                        Continent	= "Continent57530298",	
                                                                        Name	= "Name828311013",	
                                                                        Instructions	= "Instructions1567372854",	
                                                                        Ingredients	= "Ingredients1879708786",	
                                                                        Image	= "Image1008800056",	
                                                                        Vegan	= bool.Parse("Vegan525543781"),	
                                                                        Calories	= int.Parse("Calories1657505273"),	
                                                                        PreparationTime	= int.Parse("PreparationTime1702043041"),	
																	}, 	
																	new RecipeDTO {
                                                                        Continent	= "Continent1457800019",	
                                                                        Name	= "Name1466007882",	
                                                                        Instructions	= "Instructions1747597185",	
                                                                        Ingredients	= "Ingredients2027857040",	
                                                                        Image	= "Image1106895795",	
                                                                        Vegan	= bool.Parse("Vegan19789489"),	
                                                                        Calories	= int.Parse("Calories281262391"),	
                                                                        PreparationTime	= int.Parse("PreparationTime236955164"),	
																	}, 	
																	new RecipeDTO {
                                                                        Continent	= "Continent1838074078",	
                                                                        Name	= "Name776986860",	
                                                                        Instructions	= "Instructions783114202",	
                                                                        Ingredients	= "Ingredients31698819",	
                                                                        Image	= "Image1889480859",	
                                                                        Vegan	= bool.Parse("Vegan1967331571"),	
                                                                        Calories	= int.Parse("Calories1662769178"),	
                                                                        PreparationTime	= int.Parse("PreparationTime1099327670"),	
																	}, 	
																	new RecipeDTO {
                                                                        Continent	= "Continent1475053660",	
                                                                        Name	= "Name1919970149",	
                                                                        Instructions	= "Instructions1631285876",	
                                                                        Ingredients	= "Ingredients397363433",	
                                                                        Image	= "Image1372621274",	
                                                                        Vegan	= bool.Parse("Vegan1378048952"),	
                                                                        Calories	= int.Parse("Calories1626085888"),	
                                                                        PreparationTime	= int.Parse("PreparationTime1905012180"),	
																	}, 	
																	new RecipeDTO {
                                                                        Continent	= "Continent1992716285",	
                                                                        Name	= "Name993090524",	
                                                                        Instructions	= "Instructions1913021765",	
                                                                        Ingredients	= "Ingredients1699616907",	
                                                                        Image	= "Image1706692036",	
                                                                        Vegan	= bool.Parse("Vegan819370747"),	
                                                                        Calories	= int.Parse("Calories2133313727"),	
                                                                        PreparationTime	= int.Parse("PreparationTime1448933157"),	
																	}, 	
																	new RecipeDTO {
                                                                        Continent	= "Continent166766377",	
                                                                        Name	= "Name176325650",	
                                                                        Instructions	= "Instructions1630299364",	
                                                                        Ingredients	= "Ingredients1138899384",	
                                                                        Image	= "Image1002841492",	
                                                                        Vegan	= bool.Parse("Vegan1963171478"),	
                                                                        Calories	= int.Parse("Calories1348807377"),	
                                                                        PreparationTime	= int.Parse("PreparationTime1053169841"),	
																	}, 	
																	new RecipeDTO {
                                                                        Continent	= "Continent781021089",	
                                                                        Name	= "Name1998551621",	
                                                                        Instructions	= "Instructions378529681",	
                                                                        Ingredients	= "Ingredients895890719",	
                                                                        Image	= "Image1166026817",	
                                                                        Vegan	= bool.Parse("Vegan2066874283"),	
                                                                        Calories	= int.Parse("Calories1784380036"),	
                                                                        PreparationTime	= int.Parse("PreparationTime237682374"),	
																	}, 	
																	new RecipeDTO {
                                                                        Continent	= "Continent1313025482",	
                                                                        Name	= "Name468045184",	
                                                                        Instructions	= "Instructions404655126",	
                                                                        Ingredients	= "Ingredients1236313554",	
                                                                        Image	= "Image1041741552",	
                                                                        Vegan	= bool.Parse("Vegan1260141840"),	
                                                                        Calories	= int.Parse("Calories329421767"),	
                                                                        PreparationTime	= int.Parse("PreparationTime79751067"),	
																	}, 	
                                                                };
 
        public virtual RecipeDTO Find(string id)
        {
			return RecipeDTOCollection.FirstOrDefault(item => item.Id == id);
        }

        public virtual List<RecipeDTO> FindAll()
        {
            return RecipeDTOCollection;
        }
		
		public virtual List<RecipeDTO> Search(string searchValue)
        {
            return Search(searchValue, "Id", true, 0, 0);
        }

        public virtual List<RecipeDTO> Search(string searchValue, int pageIndex, int pageSize)
        {
            return Search(searchValue, "Id", true, pageIndex, pageSize);
        }

        public virtual List<RecipeDTO> Search(string searchValue, string orderBy)
        {
            return Search(searchValue, orderBy, true, 0, 0);
        }

        public virtual List<RecipeDTO> Search(string searchValue, string orderBy, int pageIndex, int pageSize)
        {
            return Search(searchValue, orderBy, true, pageIndex, pageSize);
        }

        public virtual List<RecipeDTO> Search(string searchValue, string orderBy = "", bool ascending = true, int pageIndex = 0, int pageSize = 10)
        {
			if(0 < pageSize)
			{
				return RecipeDTOCollection.Skip(pageIndex * pageSize).Take(pageSize).ToList();
			}

			return RecipeDTOCollection; 
        }

        public virtual int SearchCount(string searchValue)
        {
           return RecipeDTOCollection.Count;
        }
	}
}
