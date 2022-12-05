using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CollegueEvaluator.Data.Migrations
{
    public partial class SeedEvaluationData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Evaluations",
                columns: new[] { "Id", "EvaluatedUserName", "Performance", "Qualification", "Responsibility", "UserId", "СommunicationSkills" },
                values: new object[,]
                {
                    { "0053ca23-e47d-4388-a06c-4bad96dd3f98", "Rick_Sanchez", "Вище середньої", "Вище середньої", "Вище середнього", "f9f1461e-4c73-422c-925d-63716df3f4a2", "Вище середнього" },
                    { "04c93bb4-bd4b-4c9a-bc5d-5b72d37b8700", "Rick_Sanchez", "Вище середньої", "Вище середньої", "Вище середнього", "9e965c8d-3396-4dff-ab29-adc7a76d00b9", "Вище середнього" },
                    { "072ee08c-46a8-4728-9455-a1e1e7290042", "Rick_Sanchez", "Висока", "Нижче середньої", "Нижче середнього", "eb091681-8153-466c-94b7-a7ca35f01ec8", "Високе" },
                    { "0cc36674-e680-42b9-92ba-ed699184fd5a", "Rick_Sanchez", "Висока", "Вище середньої", "Дуже часто", "6d25c9fd-a65d-492a-84da-a40c915b1bb3", "Вище середнього" },
                    { "129de955-7aff-407b-a629-66b1098bb197", "Rick_Sanchez", "Низька", "Дуже низька", "Завжди", "c14aa275-a95a-47fb-b514-4f59d151aaf8", "Низьке" },
                    { "1f1cfa42-0e3c-4ba4-bca4-1faa7a14373c", "Rick_Sanchez", "Нижче середньої", "Висока", "Дуже часто", "c34e8e69-bb80-45f1-9e5b-e519b9da0908", "Нижче середнього" },
                    { "25d9eeeb-f18c-4dae-b098-135e591ee222", "Rick_Sanchez", "Вище середньої", "Висока", "Дуже часто", "640c6d4c-3c82-43f5-af0e-5da12b7ca56b", "Вище середнього" },
                    { "28425c75-b270-4abb-b17c-541c3d5ef341", "Rick_Sanchez", "Низька", "Низька", "Майже ніколи", "fd20492e-52a4-4b59-b97a-ba3c443b0088", "Низьке" },
                    { "3001490b-999a-4a6a-89b7-375787245119", "Rick_Sanchez", "Вище середньої", "Нижче середньої", "Вище середнього", "93b5fec0-bab2-4221-bd18-e8b3736cb9a3", "Нижче середнього" },
                    { "356374b2-17be-4ab6-af8f-bb2b3c309c90", "Rick_Sanchez", "Висока", "Висока", "Дуже часто", "ad4a4c05-9ae1-49ac-a117-d1015ae478cc", "Високе" },
                    { "3658459a-8c0f-4495-9522-245185488a00", "Rick_Sanchez", "Нижче середньої", "Вище середньої", "Нижче середнього", "efc6ea69-3394-4d00-a733-104964b2ca6f", "Вище середнього" },
                    { "3819186d-6895-43a5-83fc-1d6eb7265291", "Rick_Sanchez", "Нижче середньої", "Нижче середньої", "Нижче середнього", "7e56449f-a598-471d-9666-c0ac017319d7", "Нижче середнього" },
                    { "398b7b58-70b7-463b-ba42-3e12514603a3", "Rick_Sanchez", "Нижче середньої", "Дуже низька", "Завжди", "dc17264b-bf7a-4c32-9908-66eaa93db7e0", "Низьке" },
                    { "3ccd96e3-2c3f-4364-b7d7-865a4716eee5", "Rick_Sanchez", "Нижче середньої", "Дуже низька", "Завжди", "0347d78a-c891-4b98-8386-e3919c5cc9c4", "Низьке" },
                    { "42f14adf-68a1-46a9-b371-2ff482beef91", "Rick_Sanchez", "Вище середньої", "Нижче середньої", "Вище середнього", "a1f9aeea-8813-438c-b2fa-e620adae6662", "Нижче середнього" },
                    { "4a2a9d9b-a31a-46d2-97ab-c574289f11ce", "Rick_Sanchez", "Висока", "Вище середньої", "Дуже часто", "d9de3f01-c253-4130-875b-c9d527c9ab0d", "Дуже високе" },
                    { "4d032c5e-39fa-4e68-8b37-a9a69f2e131e", "Rick_Sanchez", "Вище середньої", "Низька", "Нижче середнього", "e5614207-a358-401a-8a49-3e078452f014", "Високе" },
                    { "5f7069f1-57c2-4cb8-94d2-cd2be8c4d4ed", "Rick_Sanchez", "Висока", "Висока", "Дуже часто", "9627361a-1308-4c14-a827-5235be64412e", "Високе" },
                    { "68c3dd6e-dd5b-4081-bf4c-74be844fef34", "Rick_Sanchez", "Нижче середньої", "Дуже низька", "Завжди", "c0f4eba4-88b8-465e-99cf-2e1b48cd52f4", "Низьке" },
                    { "70b65a79-4238-4b3d-9747-81d5d0d11355", "Rick_Sanchez", "Нижче середньої", "Дуже низька", "Завжди", "2c60ec20-9db0-41f3-8fa2-2aeeb00a0236", "Низьке" },
                    { "774d243e-4772-4d76-b98b-c9ff733bbd3d", "Rick_Sanchez", "Вище середньої", "Висока", "Завжди", "9a6532d3-5d7a-4c5a-a088-211c4dc40648", "Вище середнього" },
                    { "8d745b9e-df33-46fb-9e1e-c22d620e0fbb", "Rick_Sanchez", "Низька", "Нижче середньої", "Нижче середнього", "6b5f7196-6017-4375-b73d-6ff3b26bbf42", "Низьке" },
                    { "8ee5fdbe-b41a-41f9-a501-52c635ed78a8", "Rick_Sanchez", "Нижче середньої", "Вище середньої", "Нижче середнього", "fa8f6afb-6d5e-4a8b-8b23-f982514bee71", "Вище середнього" },
                    { "9d264910-9f91-4373-a577-7ebeb2848232", "Rick_Sanchez", "Вище середньої", "Вище середньої", "Вище середнього", "7f5f5479-93e1-4948-9dfa-b597488019b5", "Вище середнього" },
                    { "a5c21bbb-2773-4a16-a12b-64bda1c5866b", "Rick_Sanchez", "Дуже висока", "Дуже висока", "Завжди", "f426e379-8148-4d20-9637-96cb34cb6b3f", "Дуже високе" },
                    { "a7e08b2a-ecc1-4a98-bf2a-75cf6d66e936", "Rick_Sanchez", "Дуже висока", "Вище середньої", "Завжди", "27fa3bc7-616b-4af5-9cbe-aac818e638da", "Вище середнього" },
                    { "aec16cff-d685-49b8-b6fd-3903b07d953d", "Rick_Sanchez", "Низька", "Дуже низька", "Завжди", "45b6f232-aad0-4dab-b451-becc22f2c3cc", "Низьке" },
                    { "afdd3191-a081-490e-a5ba-3e8d7f6ceb76", "Rick_Sanchez", "Низька", "Дуже низька", "Завжди", "d1c67d43-0542-424e-8c7f-be53c19de61e", "Низьке" },
                    { "b137b02f-a818-4d85-9728-fb7d452883b8", "Rick_Sanchez", "Дуже низька", "Нижче середньої", "Ніколи", "df2cb449-0517-4b3f-9e6c-46be44cb90bf", "Нижче середнього" },
                    { "b365b499-390f-4717-9252-3d860fdd6657", "Rick_Sanchez", "Нижче середньої", "Низька", "Майже ніколи", "1c111e8e-9954-46b0-8eb4-43e0ce05a4fa", "Нижче середнього" },
                    { "b4dcb2e7-5de0-43ef-8efa-70b16f2b811c", "Rick_Sanchez", "Дуже низька", "Дуже низька", "Ніколи", "d01baff7-d8f5-40f9-8798-b25b1549c890", "Дуже низьке" },
                    { "b6a01e15-e7e4-454c-b131-944280315dd9", "Rick_Sanchez", "Дуже висока", "Вище середньої", "Завжди", "1a44ec87-b909-4889-a758-4529ba21cbd1", "Високе" },
                    { "cc853e51-111a-4dea-9b02-32d984091f9a", "Rick_Sanchez", "Висока", "Низька", "Нижче середнього", "99a639c6-5dfa-411a-8997-505be7698b48", "Високе" },
                    { "cec5fc2d-fd23-4aa3-8256-235fda6c6a46", "Rick_Sanchez", "Нижче середньої", "Нижче середньої", "Нижче середнього", "116cd90a-de19-45c1-8719-0f7e7fa2e16c", "Нижче середнього" },
                    { "cf0be48c-4723-4fa1-9d33-0a718ebf8fde", "Rick_Sanchez", "Нижче середньої", "Дуже висока", "Завжди", "281a7064-80f4-4076-a6ad-ca66a892a070", "Нижче середнього" },
                    { "d9bf4736-9e9d-471d-9677-6efa4542569b", "Rick_Sanchez", "Вище середньої", "Вище середньої", "Вище середнього", "5590cddb-be86-46f1-ad34-08a32a2bde2c", "Вище середнього" },
                    { "e13f4ac5-6a84-4d93-822d-ae9bcb13635b", "Rick_Sanchez", "Дуже висока", "Нижче середньої", "Нижче середнього", "e213a476-a1de-4140-92e3-da24df33c930", "Дуже високе" },
                    { "e5fb9138-a188-4e1b-b23f-aecee08707fa", "Rick_Sanchez", "Дуже висока", "Нижче середньої", "Завжди", "6e3b12e8-8c2c-4959-8303-a55ea2f4f87b", "Нижче середнього" },
                    { "ebdfc705-81dc-4ce9-88a9-342aa07d6ebc", "Rick_Sanchez", "Нижче середньої", "Дуже висока", "Нижче середнього", "d4d13c22-7996-4fdb-acd1-0e369560545b", "Дуже високе" },
                    { "f393f673-779f-4b1d-b03a-7b7d3a6c8cc2", "Rick_Sanchez", "Висока", "Нижче середньої", "Вище середнього", "9feb3ed4-1176-44a9-aea0-5cefdf77b9b4", "Високе" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Evaluations",
                keyColumn: "Id",
                keyValue: "0053ca23-e47d-4388-a06c-4bad96dd3f98");

            migrationBuilder.DeleteData(
                table: "Evaluations",
                keyColumn: "Id",
                keyValue: "04c93bb4-bd4b-4c9a-bc5d-5b72d37b8700");

            migrationBuilder.DeleteData(
                table: "Evaluations",
                keyColumn: "Id",
                keyValue: "072ee08c-46a8-4728-9455-a1e1e7290042");

            migrationBuilder.DeleteData(
                table: "Evaluations",
                keyColumn: "Id",
                keyValue: "0cc36674-e680-42b9-92ba-ed699184fd5a");

            migrationBuilder.DeleteData(
                table: "Evaluations",
                keyColumn: "Id",
                keyValue: "129de955-7aff-407b-a629-66b1098bb197");

            migrationBuilder.DeleteData(
                table: "Evaluations",
                keyColumn: "Id",
                keyValue: "1f1cfa42-0e3c-4ba4-bca4-1faa7a14373c");

            migrationBuilder.DeleteData(
                table: "Evaluations",
                keyColumn: "Id",
                keyValue: "25d9eeeb-f18c-4dae-b098-135e591ee222");

            migrationBuilder.DeleteData(
                table: "Evaluations",
                keyColumn: "Id",
                keyValue: "28425c75-b270-4abb-b17c-541c3d5ef341");

            migrationBuilder.DeleteData(
                table: "Evaluations",
                keyColumn: "Id",
                keyValue: "3001490b-999a-4a6a-89b7-375787245119");

            migrationBuilder.DeleteData(
                table: "Evaluations",
                keyColumn: "Id",
                keyValue: "356374b2-17be-4ab6-af8f-bb2b3c309c90");

            migrationBuilder.DeleteData(
                table: "Evaluations",
                keyColumn: "Id",
                keyValue: "3658459a-8c0f-4495-9522-245185488a00");

            migrationBuilder.DeleteData(
                table: "Evaluations",
                keyColumn: "Id",
                keyValue: "3819186d-6895-43a5-83fc-1d6eb7265291");

            migrationBuilder.DeleteData(
                table: "Evaluations",
                keyColumn: "Id",
                keyValue: "398b7b58-70b7-463b-ba42-3e12514603a3");

            migrationBuilder.DeleteData(
                table: "Evaluations",
                keyColumn: "Id",
                keyValue: "3ccd96e3-2c3f-4364-b7d7-865a4716eee5");

            migrationBuilder.DeleteData(
                table: "Evaluations",
                keyColumn: "Id",
                keyValue: "42f14adf-68a1-46a9-b371-2ff482beef91");

            migrationBuilder.DeleteData(
                table: "Evaluations",
                keyColumn: "Id",
                keyValue: "4a2a9d9b-a31a-46d2-97ab-c574289f11ce");

            migrationBuilder.DeleteData(
                table: "Evaluations",
                keyColumn: "Id",
                keyValue: "4d032c5e-39fa-4e68-8b37-a9a69f2e131e");

            migrationBuilder.DeleteData(
                table: "Evaluations",
                keyColumn: "Id",
                keyValue: "5f7069f1-57c2-4cb8-94d2-cd2be8c4d4ed");

            migrationBuilder.DeleteData(
                table: "Evaluations",
                keyColumn: "Id",
                keyValue: "68c3dd6e-dd5b-4081-bf4c-74be844fef34");

            migrationBuilder.DeleteData(
                table: "Evaluations",
                keyColumn: "Id",
                keyValue: "70b65a79-4238-4b3d-9747-81d5d0d11355");

            migrationBuilder.DeleteData(
                table: "Evaluations",
                keyColumn: "Id",
                keyValue: "774d243e-4772-4d76-b98b-c9ff733bbd3d");

            migrationBuilder.DeleteData(
                table: "Evaluations",
                keyColumn: "Id",
                keyValue: "8d745b9e-df33-46fb-9e1e-c22d620e0fbb");

            migrationBuilder.DeleteData(
                table: "Evaluations",
                keyColumn: "Id",
                keyValue: "8ee5fdbe-b41a-41f9-a501-52c635ed78a8");

            migrationBuilder.DeleteData(
                table: "Evaluations",
                keyColumn: "Id",
                keyValue: "9d264910-9f91-4373-a577-7ebeb2848232");

            migrationBuilder.DeleteData(
                table: "Evaluations",
                keyColumn: "Id",
                keyValue: "a5c21bbb-2773-4a16-a12b-64bda1c5866b");

            migrationBuilder.DeleteData(
                table: "Evaluations",
                keyColumn: "Id",
                keyValue: "a7e08b2a-ecc1-4a98-bf2a-75cf6d66e936");

            migrationBuilder.DeleteData(
                table: "Evaluations",
                keyColumn: "Id",
                keyValue: "aec16cff-d685-49b8-b6fd-3903b07d953d");

            migrationBuilder.DeleteData(
                table: "Evaluations",
                keyColumn: "Id",
                keyValue: "afdd3191-a081-490e-a5ba-3e8d7f6ceb76");

            migrationBuilder.DeleteData(
                table: "Evaluations",
                keyColumn: "Id",
                keyValue: "b137b02f-a818-4d85-9728-fb7d452883b8");

            migrationBuilder.DeleteData(
                table: "Evaluations",
                keyColumn: "Id",
                keyValue: "b365b499-390f-4717-9252-3d860fdd6657");

            migrationBuilder.DeleteData(
                table: "Evaluations",
                keyColumn: "Id",
                keyValue: "b4dcb2e7-5de0-43ef-8efa-70b16f2b811c");

            migrationBuilder.DeleteData(
                table: "Evaluations",
                keyColumn: "Id",
                keyValue: "b6a01e15-e7e4-454c-b131-944280315dd9");

            migrationBuilder.DeleteData(
                table: "Evaluations",
                keyColumn: "Id",
                keyValue: "cc853e51-111a-4dea-9b02-32d984091f9a");

            migrationBuilder.DeleteData(
                table: "Evaluations",
                keyColumn: "Id",
                keyValue: "cec5fc2d-fd23-4aa3-8256-235fda6c6a46");

            migrationBuilder.DeleteData(
                table: "Evaluations",
                keyColumn: "Id",
                keyValue: "cf0be48c-4723-4fa1-9d33-0a718ebf8fde");

            migrationBuilder.DeleteData(
                table: "Evaluations",
                keyColumn: "Id",
                keyValue: "d9bf4736-9e9d-471d-9677-6efa4542569b");

            migrationBuilder.DeleteData(
                table: "Evaluations",
                keyColumn: "Id",
                keyValue: "e13f4ac5-6a84-4d93-822d-ae9bcb13635b");

            migrationBuilder.DeleteData(
                table: "Evaluations",
                keyColumn: "Id",
                keyValue: "e5fb9138-a188-4e1b-b23f-aecee08707fa");

            migrationBuilder.DeleteData(
                table: "Evaluations",
                keyColumn: "Id",
                keyValue: "ebdfc705-81dc-4ce9-88a9-342aa07d6ebc");

            migrationBuilder.DeleteData(
                table: "Evaluations",
                keyColumn: "Id",
                keyValue: "f393f673-779f-4b1d-b03a-7b7d3a6c8cc2");
        }
    }
}
