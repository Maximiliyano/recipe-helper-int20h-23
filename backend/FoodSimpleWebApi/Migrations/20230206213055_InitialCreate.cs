﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodSimpleWebApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Difficult = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Count = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecipeDtoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Recipes_RecipeDtoId",
                        column: x => x.RecipeDtoId,
                        principalTable: "Recipes",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Count", "Name", "RecipeDtoId", "Unit" },
                values: new object[,]
                {
                    { 1, "Sweet", "1", "ABMMGKJPPH", null, "G" },
                    { 2, "Fatty", "9", "OWURMEVYPS", null, "G" },
                    { 3, "Vegetables", "8", "IPQOYUSYHW", null, "Ml" },
                    { 4, "Fish", "8", "BAFNWRMCYY", null, "G" },
                    { 5, "Fruits", "4", "VZZHHSAQFM", null, "Pcs" },
                    { 6, "Meal", "4", "UGOWWJZXGT", null, "Pcs" },
                    { 7, "Fatty", "4", "DNPOLNPHKF", null, "Pcs" },
                    { 8, "Sweet", "5", "URGOVVUAPK", null, "Ml" },
                    { 9, "Meal", "7", "XWQWVLCHYD", null, "Pcs" },
                    { 10, "Fatty", "7", "XFGRSAUVKZ", null, "G" }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "Description", "Difficult", "Image", "Name" },
                values: new object[,]
                {
                    { 1, "UTLRXJXPJAQMWYQCIUTTXZUAVCJVFCTKMSJTSMWCYUWSSFUWUAQUDWIMCMFCEPAHQJYJROURAUMJDVJSEIUVJEHVMXYIXCNECMPVHMTGLFNYFBNNPIXVXJBCMTPPMOGJGNHDRMZFEUUHWSKXLGOJNDUUXLKNSKIIUUSRPUEFHHXYSZJSMWCDONMPCXAFGTIOIUVXDVJBUXKCEIAQVSSCBCJZKMBCGASZCLNIQFYBYYHCFLWRCZKJUCFLUEMOQOHWHBLWJUFVDESAEXVBEDYYTLOPRGFMKIRQMGSDYJOSHMQNTHDNTOUORVMPGJNYJRYTDOMWPKKBRVQVXJPMZPOWXLXFRIZQTYWBZSCRJUZXGHJOROEDPINXTEPKXOUKLAIKVMCVYIEBKRLWQNMDGELCVGWPGUUJGLTATUZGFEJRRMINOWHJPTLDYKUTKAAEQHVABVDRSOQZAJWNNODZJMNHWVDVZIUQUUINEMIYUYOXIEJSLOAJHJVM", 1, null, "DUXPGNUCEI" },
                    { 2, "ZTUOSPODUQQLSKLTSBOOPKJIHHTKDXGEDPYTYDATVQZPIVFRRCHVGRCPUGAVWJWRFGDRQXBSCNFYDLEGKLNFTMYDGRDUVFXMYJNPZVTNKXMEIXIHFPXUEOGGKWNASBIZCEWVYDJNOSOPJSSCQTZCRDCPZLVTSYNDEHPENILXJZIGRSYYFFOCCRFRQELQFZYCEQTUPNDHSPCGRLCLEZUGUXTCCVEUIFVXUSVQMEFMZFUIRRMUKZOQWPQDYKCEOISAYIHZBJTMFMRYTIQVLCCIZRYDIOLPEQOBWVRIWNXWQRAFSWOGIZFZIBZFRORNNFFBWAGFRDBCSPUWBUJRNZDFTAUNLVIUDPHIEZMJIWOCZUPRMULQYFAVNLEWXUKVFPENCXIEOWDRQUAGOTJWZLSYKEJHYIKIZGHJZWSECCBRWROCTXAZKJYTTQPBMVOJDPOQONQWAVVQKXWGOCFPQTHEYCWSYMSQMSHCORBTWKETPNQTJFTAPPWA", 3, null, "PITIZDBKQF" },
                    { 3, "JLLYVAHNFARUWIOBMDNMONAEYEEZWUPOQNXDENOMZPIXKXQALPOWTVAKKJYKYEWHZLKRJVCSAHLVWCFLVWDSZAPCIJJNDNDRTDZPEKFFQKLZYOPNBKDAKPSLAWHEXDSQRPMMBDOBUYSNIRXBLGSYVJURLHWVDTRSVGUOXLCHWHPFANHROSKSHCOYVOGVRSJQYARQHMQDBARZMIATLTRRKWOHXMXGMHDUDSIPRFLQOBTISPKCTXHYLZBQOFSLRDLELJXUVBDDQBONBWYEUCVODIJGAHNVFOEWCAMEASOYCAQVCOVWAKLQSUMSVBBDLHRIPWXHWSHKNEQPIOQRJVJWCEKITIWUKPIMXKIQRNCNZMDKRZHYHVYCEQLRWKXRZGQDFZGZJUZKSCYXEFABVCMSKMDQPMUOTIBTHHQSOWUPIHSUGVGZDDSORDMLUBUXAKXYEAKKWDVAOPCYCHAXVYZVNDVAHCZDFILBKWBPMDYKYEDUGXYDFCZL", 3, null, "UOSOXWEESM" },
                    { 4, "SUJPQUIHNHWUJRTXSONLKZLIEVFFKXOZPTUAMSVHWHUKBXEVDOCXPICNZPJNFRRZYWAKZAWYCANPFOYBZNCEXULEVNVFXISYDZGHTMTFQXHVRRDDWKZQNOIYFJTRZHUEXUALLLPPIKBWMQDHCSUKXRBIRRWJHHIMXHBQTAFMJOYNVNMZGXSHYNALDXIJXYHSUNZOGKONCWAHJVWFDSVPAWQRJZYNUHZYYCXTFURZNSUDTJCMFAQICQWERAEOAVXRLXDADGRRDKMSLGFCJGIKAFIAIXZSINRMHUJZASXZZUQRQCLAHCLPSGMYMCZQCTBKXJUTLPWTENEXEYQHIOCMWSUPCLYXDQJRDDPPDZIWDBBQAJYXSTGTKMSFGKKLIWTYTUFJUTFVGUEIZANAHEMOSBHZZJKJUZMTLCHSOMXJRTZMUSOSAUHLZMTPLGMYMPWIXIQDTEPMHXIEVXBFRDTDUGZRZFZXFEHJMOIGSBVKGNZXRTHYTOGD", 2, null, "AOUZPEOHAN" },
                    { 5, "ADMQWQMYITUMMFWAJMNBRMNXVISWGMVRWQWRFAYXACFUASOKBUVAQNKACMNYRSRPBAFVGAPWCMKKUHUFCHGPGVXAVJMVICRETZHHQRGSZIYXWQRAAZCJATHGXGSOEGUTGCSGDLNMWKOZIWVEGGXAJPWQMMHXUQXUHSDHTIBSBMFZVUNTULQIMNTCTNZLIKOWJBEKHMAPOWXMACPXXIWNIOSXKANCRVMCHLVXYGWLOJKTJBBWHJETFDUDEPPLGIBUZQXVWTKNSZXYDOHNFRAQCFNOZWHMZSRGWFQHSLXGNRKLTFZPWYOJMDWPJTSSCRTKVNXDSWXSRZJLQRQWTFVLUPBHUOAYLDNBHWOWMACVJQULMFJMOAMIGBROVRSSHTKNSHUGDPKJMLXXGZUNYVLKMWQCVUDLTQCLOWNMZNBLFHRAQOGTFFNMBKMUAIHXKQHJXYYIKTLFCNHJZOJFCGEQZNHMDVFIBSVCIJACNJPWSOHAKVWMWFNQ", 3, null, "ERNEUWIXTI" },
                    { 6, "MPRSKREGGHEALUNOZOEALTBGEBPJHQJOFKXSDFMPPFUQUFPLPMAJRUYMNHLRATCNQFZYYLBQKOTTPTAGBMJCMDWZFEMQXKCQXTGSNFKBNUJNWEVIAGTRZEZHMQEOKOHEZQKGZQQFNCBSGXMWRFEYQZKYXDJHVZJBSGVVLSEMQMFDWTFWKTQUHUVSOTYARQYPHDGRLADCAYJCCLNEHGSEUTJSPVWCTYPOBISITFZAASCKAGWFWVFMBZDTBETXWIHXQPATGBGOQUHOZYXRPLJBIORZDFJUNRZWIBQJDKIDLEQSWKXSLGYJYCGMDCIFZBXCHRNGIDHISRCZQBZZWHWPRKBJWPKLGOCFZJMJQQMXYUZJEUSBTWBYWLBZLNINKJWFBVBDZSAMKVDAZUGGOHWUZBARTFITPGEZVMIJIZYVJDDXTRDMBMPHNIWRXXMEVNXKYGBPHLMYIMKMCZCEPFAWCLRIHZIHZLLDUKVKMMUBGTBZYIEBIRRJ", 2, null, "CAKSFXQWGF" },
                    { 7, "GNKXWRVRNMXZSUBVAUAFKDSMYJFPHQYIBFIESZVUVMQBHDJOVZISKLBAZNZKLYDPXYPDSQFMVQMPEQHSBAJZOUKRIBNMLQNLDXZUXMTAFDZTCHFPGAGOIMVBJQVFEHLJFXONTQXBDZHEBWJLWFLVCRLFWIMNKXERCWXNWHIITMEUSUPHIVRSOZUDDAYCAOLUTSOVZXLUPNWHPXQPESWXRXUSEHCKLKOCAQDOYJNOXTYCPYITYXAVBFHOTLHINWBWEFHQVDCVMGBVQIQUOMKYMLJOVQIUFBMONJZRIMXAASNTSRPQXVYJUQEZWIIODIRDPKJKHKAZTRAJLZTJMMPFSRCGVSLZGMEDUFZUTRVGLTSUCUHONBINXRWYPDQWUSWOTRZYZMMBCKDXAMUIBXOBJRQIDDTNITSBTUBCHHIZSEDIFKKJQGPVEKRGGRZVZIGMPWTKFVKFBQITNKPELWRVUYVTXQSRHBLCGVYVGAVNYOAULJHYOEJD", 2, null, "XIUEIAIOJV" },
                    { 8, "GZRJQCYRCUAZPNPNJWBGDGGIJWARDGHCGELNGWNGWXRUCORUAEBQZXRMGRRHXRMIEXSYJZVSJRNFBPZEEBFPXDAIHBQOBTMVEWILTAAVUWZZCLOLXTYLIVPXFNCVIUAZLAIGXUCIJJQLOAQIWIIHVZYTXJFUHDEXTSLWFPGQHDIRYHNILMJIJNHAUPFIVASQJWJJWHWEXUBQCMDHDVLTCEBSNAIFHTBFVUUTFARSFMZEMWHNFVTTAOCBPPFXFMFBSZDCICMMHUFTKDQPAZXJYBPPHCDPLOJEERNXNLJMDRKWKFONORMXSNXDCZTGOAGSLKUKYKCOQAJZJHQQFFSVQVPJFUOZNRVQXZCISSJICQIGGYQJDKVEEFNGISOXNRHYOWBVNNXUTXUTNBMHAZZOFDNZXJKROGQYDRBSKAAZBWXENAZSWIZFJIPUBMJASCLFISSQQQBXAVLHQQTWPWVJWGWHWBHNOBBTDPAXVLJINRPSOOYDOPRT", 2, null, "LVJRBAJPKD" },
                    { 9, "JDKQYKJLOFHLJICDITPOAXNRHTKDZWAXHKSXFSCRFKXFAXZNSQJHCYIJHRHOQLMOLMDGAOCATOQPGJNDSQWAFVATUDWYFJSTBFZDBDPSQUKDDENBPJYUUBQCRIIJWIAZZDUBRFZAKVFZYLNMPLBZZMKUBQEUEUAJMLYTLIZQDGEBWPFYJQPIWESQHNWMAAZMUSXIEMCWAINRMITJJMTBKGQRDEOJGOTJJRGNFPGJIZDTJCFAOHRKCBVHDKTHKDMMHGITXEPZKYXTKIZOHDCGYQUPNHAZFBXJDAMFJSIPQWRGHQHXMKQYZUTEQHWTOJJDMKWJJWEDBUCWPRCFQGEMAVKFWHNGOPWBFQOLLWGYRWQSGODLJWVSWFLZWMGFAYSNSYWWCHFVYRAHMQIQAHOFVRTGREOLHQEJDDVYZQRWWXFUZCITZARYVSVLIFGZZEICKESVBLAXLOMLXLQCBJHVUBKXSWYGTZQNCKDZYZHWEFBOLAVSSOWQ", 1, null, "TNZLUUFNSR" },
                    { 10, "MVKCQZJBGBSBEIKEROWVLSVKTTHFQGHWESTZNEXSKNFALGXHFWICSBSTIWGMGMHETROGDFQWUCQJMNYMODXRQNBOGPHUTLEWGWQFUVXTSBOUTYQGBEQKLGWZPZISQBZRQOXMCSBLAGBHCBBIHRFQSOYFTQBTPFMOKJUZOAQAVIMHWOMIPHPBJBXRKTZOXMZBHPHORBQWOBWVRLATMJCYCMGXVLRIUJCPJTCCPSOXFMUJYVOLMZZFYYIRMMTJKYQMSHZKYITYUMGTUGNGAEEKRADCPNGYULESORPPTWKRQGCNRBALDHNITRVSTNAXLAOJJEZIGYRYOJRKNMTLTIKWASWXGBVZYTGJNTHXFFXNEUREWZMIILEMQZRFHSTCECJCZNTIQKQDNFOJVJQVADFMDSYNWXGOGXCUSEPLADXWEKPTNHBUPEOSESLPFMOWRZXFQFFIKYQVCAZVMUZGWNAWYLGEWHZHGMWMIGCCFYKDLYHDMOYBVRJM", 3, null, "VGGKKTEWCL" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email" },
                values: new object[,]
                {
                    { 1, "IRTAMGZ@gmail.com" },
                    { 2, "VXMEPTY@gmail.com" },
                    { 3, "PRIFTBD@gmail.com" },
                    { 4, "CWWEISB@gmail.com" },
                    { 5, "BIPHVKT@gmail.com" },
                    { 6, "CCUPARY@gmail.com" },
                    { 7, "QZCOETK@gmail.com" },
                    { 8, "VPNFIJY@gmail.com" },
                    { 9, "OAPVFPT@gmail.com" },
                    { 10, "NJYADQL@gmail.com" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_RecipeDtoId",
                table: "Products",
                column: "RecipeDtoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Recipes");
        }
    }
}