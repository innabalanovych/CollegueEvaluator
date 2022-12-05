using ColleagueEvaluator.Logic.Constants;
using CollegueEvaluator.Models;

namespace CollegueEvaluator.Data
{
    public static class SeedingData
    {
        public static List<Evaluation> GetEvaluations()
        {
            return new List<Evaluation>
            {
                new Evaluation
                {
                    Id     = "4d032c5e-39fa-4e68-8b37-a9a69f2e131e",
                    UserId = "e5614207-a358-401a-8a49-3e078452f014",
                    EvaluatedUserName = "Rick_Sanchez",
                    Performance = EvaluationConstants.Performance.MoreAverage,
                    Qualification = EvaluationConstants.Qualification.Low,
                    Responsibility = EvaluationConstants.Responsibility.LessAverage,
                    СommunicationSkills = EvaluationConstants.СommunicationSkills.High
                },
                new Evaluation
                {
                    Id     = "b137b02f-a818-4d85-9728-fb7d452883b8",
                    UserId = "df2cb449-0517-4b3f-9e6c-46be44cb90bf",
                    EvaluatedUserName = "Rick_Sanchez",
                    Performance = EvaluationConstants.Performance.VeryLow,
                    Qualification = EvaluationConstants.Qualification.LessAverage,
                    Responsibility = EvaluationConstants.Responsibility.VeryLow,
                    СommunicationSkills = EvaluationConstants.СommunicationSkills.LessAverage
                },
                new Evaluation
                {
                    Id     = "129de955-7aff-407b-a629-66b1098bb197",
                    UserId = "c14aa275-a95a-47fb-b514-4f59d151aaf8",
                    EvaluatedUserName = "Rick_Sanchez",
                    Performance = EvaluationConstants.Performance.Low,
                    Qualification = EvaluationConstants.Qualification.VeryLow,
                    Responsibility = EvaluationConstants.Responsibility.VeryHigh,
                    СommunicationSkills = EvaluationConstants.СommunicationSkills.Low,
                },
                new Evaluation
                {
                    Id     = "afdd3191-a081-490e-a5ba-3e8d7f6ceb76",
                    UserId = "d1c67d43-0542-424e-8c7f-be53c19de61e",
                    EvaluatedUserName = "Rick_Sanchez",
                    Performance = EvaluationConstants.Performance.Low,
                    Qualification = EvaluationConstants.Qualification.VeryLow,
                    Responsibility = EvaluationConstants.Responsibility.VeryHigh,
                    СommunicationSkills = EvaluationConstants.СommunicationSkills.Low,
                },
                new Evaluation
                {
                    Id     = "aec16cff-d685-49b8-b6fd-3903b07d953d",
                    UserId = "45b6f232-aad0-4dab-b451-becc22f2c3cc",
                    EvaluatedUserName = "Rick_Sanchez",
                    Performance = EvaluationConstants.Performance.Low,
                    Qualification = EvaluationConstants.Qualification.VeryLow,
                    Responsibility = EvaluationConstants.Responsibility.VeryHigh,
                    СommunicationSkills = EvaluationConstants.СommunicationSkills.Low,
                },
                new Evaluation
                {
                    Id     = "398b7b58-70b7-463b-ba42-3e12514603a3",
                    UserId = "dc17264b-bf7a-4c32-9908-66eaa93db7e0",
                    EvaluatedUserName = "Rick_Sanchez",
                    Performance = EvaluationConstants.Performance.LessAverage,
                    Qualification = EvaluationConstants.Qualification.VeryLow,
                    Responsibility = EvaluationConstants.Responsibility.VeryHigh,
                    СommunicationSkills = EvaluationConstants.СommunicationSkills.Low,
                },
                new Evaluation
                {
                    Id     = "70b65a79-4238-4b3d-9747-81d5d0d11355",
                    UserId = "2c60ec20-9db0-41f3-8fa2-2aeeb00a0236",
                    EvaluatedUserName = "Rick_Sanchez",
                    Performance = EvaluationConstants.Performance.LessAverage,
                    Qualification = EvaluationConstants.Qualification.VeryLow,
                    Responsibility = EvaluationConstants.Responsibility.VeryHigh,
                    СommunicationSkills = EvaluationConstants.СommunicationSkills.Low,
                },
                new Evaluation
                {
                    Id     = "68c3dd6e-dd5b-4081-bf4c-74be844fef34",
                    UserId = "c0f4eba4-88b8-465e-99cf-2e1b48cd52f4",
                    EvaluatedUserName = "Rick_Sanchez",
                    Performance = EvaluationConstants.Performance.LessAverage,
                    Qualification = EvaluationConstants.Qualification.VeryLow,
                    Responsibility = EvaluationConstants.Responsibility.VeryHigh,
                    СommunicationSkills = EvaluationConstants.СommunicationSkills.Low,
                },
                new Evaluation
                {
                    Id     = "3ccd96e3-2c3f-4364-b7d7-865a4716eee5",
                    UserId = "0347d78a-c891-4b98-8386-e3919c5cc9c4",
                    EvaluatedUserName = "Rick_Sanchez",
                    Performance = EvaluationConstants.Performance.LessAverage,
                    Qualification = EvaluationConstants.Qualification.VeryLow,
                    Responsibility = EvaluationConstants.Responsibility.VeryHigh,
                    СommunicationSkills = EvaluationConstants.СommunicationSkills.Low,
                },
                new Evaluation
                {
                    Id     = "8d745b9e-df33-46fb-9e1e-c22d620e0fbb",
                    UserId = "6b5f7196-6017-4375-b73d-6ff3b26bbf42",
                    EvaluatedUserName = "Rick_Sanchez",
                    Performance = EvaluationConstants.Performance.Low,
                    Qualification = EvaluationConstants.Qualification.LessAverage,
                    Responsibility = EvaluationConstants.Responsibility.LessAverage,
                    СommunicationSkills = EvaluationConstants.СommunicationSkills.Low
                },
                new Evaluation
                {
                    Id     = "b365b499-390f-4717-9252-3d860fdd6657",
                    UserId = "1c111e8e-9954-46b0-8eb4-43e0ce05a4fa",
                    EvaluatedUserName = "Rick_Sanchez",
                    Performance = EvaluationConstants.Performance.LessAverage,
                    Qualification = EvaluationConstants.Qualification.Low,
                    Responsibility = EvaluationConstants.Responsibility.Low,
                    СommunicationSkills = EvaluationConstants.СommunicationSkills.LessAverage
                },
                new Evaluation
                {
                    Id     = "1f1cfa42-0e3c-4ba4-bca4-1faa7a14373c",
                    UserId = "c34e8e69-bb80-45f1-9e5b-e519b9da0908",
                    EvaluatedUserName = "Rick_Sanchez",
                    Performance = EvaluationConstants.Performance.LessAverage,
                    Qualification = EvaluationConstants.Qualification.High,
                    Responsibility = EvaluationConstants.Responsibility.High,
                    СommunicationSkills = EvaluationConstants.СommunicationSkills.LessAverage
                },
                new Evaluation
                {
                    Id     = "072ee08c-46a8-4728-9455-a1e1e7290042",
                    UserId = "eb091681-8153-466c-94b7-a7ca35f01ec8",
                    EvaluatedUserName = "Rick_Sanchez",
                    Performance = EvaluationConstants.Performance.High,
                    Qualification = EvaluationConstants.Qualification.LessAverage,
                    Responsibility = EvaluationConstants.Responsibility.LessAverage,
                    СommunicationSkills = EvaluationConstants.СommunicationSkills.High
                },
                new Evaluation
                {
                    Id     = "cf0be48c-4723-4fa1-9d33-0a718ebf8fde",
                    UserId = "281a7064-80f4-4076-a6ad-ca66a892a070",
                    EvaluatedUserName = "Rick_Sanchez",
                    Performance = EvaluationConstants.Performance.LessAverage,
                    Qualification = EvaluationConstants.Qualification.VeryHigh,
                    Responsibility = EvaluationConstants.Responsibility.VeryHigh,
                    СommunicationSkills = EvaluationConstants.СommunicationSkills.LessAverage
                },
                new Evaluation
                {
                    Id     = "e13f4ac5-6a84-4d93-822d-ae9bcb13635b",
                    UserId = "e213a476-a1de-4140-92e3-da24df33c930",
                    EvaluatedUserName = "Rick_Sanchez",
                    Performance = EvaluationConstants.Performance.VeryHigh,
                    Qualification = EvaluationConstants.Qualification.LessAverage,
                    Responsibility = EvaluationConstants.Responsibility.LessAverage,
                    СommunicationSkills = EvaluationConstants.СommunicationSkills.VeryHigh
                },
                new Evaluation
                {
                    Id     = "5f7069f1-57c2-4cb8-94d2-cd2be8c4d4ed",
                    UserId = "9627361a-1308-4c14-a827-5235be64412e",
                    EvaluatedUserName = "Rick_Sanchez",
                    Performance = EvaluationConstants.Performance.High,
                    Qualification = EvaluationConstants.Qualification.High,
                    Responsibility = EvaluationConstants.Responsibility.High,
                    СommunicationSkills = EvaluationConstants.СommunicationSkills.High
                },
                new Evaluation
                {
                    Id     = "8ee5fdbe-b41a-41f9-a501-52c635ed78a8",
                    UserId = "fa8f6afb-6d5e-4a8b-8b23-f982514bee71",
                    EvaluatedUserName = "Rick_Sanchez",
                    Performance = EvaluationConstants.Performance.LessAverage,
                    Qualification = EvaluationConstants.Qualification.MoreAverage,
                    Responsibility = EvaluationConstants.Responsibility.LessAverage,
                    СommunicationSkills = EvaluationConstants.СommunicationSkills.MoreAverage
                },
                new Evaluation
                {
                    Id     = "42f14adf-68a1-46a9-b371-2ff482beef91",
                    UserId = "a1f9aeea-8813-438c-b2fa-e620adae6662",
                    EvaluatedUserName = "Rick_Sanchez",
                    Performance = EvaluationConstants.Performance.MoreAverage,
                    Qualification = EvaluationConstants.Qualification.LessAverage,
                    Responsibility = EvaluationConstants.Responsibility.MoreAverage,
                    СommunicationSkills = EvaluationConstants.СommunicationSkills.LessAverage
                },
                new Evaluation
                {
                    Id     = "28425c75-b270-4abb-b17c-541c3d5ef341",
                    UserId = "fd20492e-52a4-4b59-b97a-ba3c443b0088",
                    EvaluatedUserName = "Rick_Sanchez",
                    Performance = EvaluationConstants.Performance.Low,
                    Qualification = EvaluationConstants.Qualification.Low,
                    Responsibility = EvaluationConstants.Responsibility.Low,
                    СommunicationSkills = EvaluationConstants.СommunicationSkills.Low
                },
                new Evaluation
                {
                    Id     = "0053ca23-e47d-4388-a06c-4bad96dd3f98",
                    UserId = "f9f1461e-4c73-422c-925d-63716df3f4a2",
                    EvaluatedUserName = "Rick_Sanchez",
                    Performance = EvaluationConstants.Performance.MoreAverage,
                    Qualification = EvaluationConstants.Qualification.MoreAverage,
                    Responsibility = EvaluationConstants.Responsibility.MoreAverage,
                    СommunicationSkills = EvaluationConstants.СommunicationSkills.MoreAverage
                },
                new Evaluation
                {
                    Id     = "04c93bb4-bd4b-4c9a-bc5d-5b72d37b8700",
                    UserId = "9e965c8d-3396-4dff-ab29-adc7a76d00b9",
                    EvaluatedUserName = "Rick_Sanchez",
                    Performance = EvaluationConstants.Performance.MoreAverage,
                    Qualification = EvaluationConstants.Qualification.MoreAverage,
                    Responsibility = EvaluationConstants.Responsibility.MoreAverage,
                    СommunicationSkills = EvaluationConstants.СommunicationSkills.MoreAverage
                },
                new Evaluation
                {
                    Id     = "e5fb9138-a188-4e1b-b23f-aecee08707fa",
                    UserId = "6e3b12e8-8c2c-4959-8303-a55ea2f4f87b",
                    EvaluatedUserName = "Rick_Sanchez",
                    Performance = EvaluationConstants.Performance.VeryHigh,
                    Qualification = EvaluationConstants.Qualification.LessAverage,
                    Responsibility = EvaluationConstants.Responsibility.VeryHigh,
                    СommunicationSkills = EvaluationConstants.СommunicationSkills.LessAverage
                },
                new Evaluation
                {
                    Id     = "ebdfc705-81dc-4ce9-88a9-342aa07d6ebc",
                    UserId = "d4d13c22-7996-4fdb-acd1-0e369560545b",
                    EvaluatedUserName = "Rick_Sanchez",
                    Performance = EvaluationConstants.Performance.LessAverage,
                    Qualification = EvaluationConstants.Qualification.VeryHigh,
                    Responsibility = EvaluationConstants.Responsibility.LessAverage,
                    СommunicationSkills = EvaluationConstants.СommunicationSkills.VeryHigh
                },
                new Evaluation
                {
                    Id     = "b6a01e15-e7e4-454c-b131-944280315dd9",
                    UserId = "1a44ec87-b909-4889-a758-4529ba21cbd1",
                    EvaluatedUserName = "Rick_Sanchez",
                    Performance = EvaluationConstants.Performance.VeryHigh,
                    Qualification = EvaluationConstants.Qualification.MoreAverage,
                    Responsibility = EvaluationConstants.Responsibility.VeryHigh,
                    СommunicationSkills = EvaluationConstants.СommunicationSkills.High
                },
                new Evaluation
                {
                    Id     = "25d9eeeb-f18c-4dae-b098-135e591ee222",
                    UserId = "640c6d4c-3c82-43f5-af0e-5da12b7ca56b",
                    EvaluatedUserName = "Rick_Sanchez",
                    Performance = EvaluationConstants.Performance.MoreAverage,
                    Qualification = EvaluationConstants.Qualification.High,
                    Responsibility = EvaluationConstants.Responsibility.High,
                    СommunicationSkills = EvaluationConstants.СommunicationSkills.MoreAverage
                },
                new Evaluation
                {
                    Id     = "0cc36674-e680-42b9-92ba-ed699184fd5a",
                    UserId = "6d25c9fd-a65d-492a-84da-a40c915b1bb3",
                    EvaluatedUserName = "Rick_Sanchez",
                    Performance = EvaluationConstants.Performance.High,
                    Qualification = EvaluationConstants.Qualification.MoreAverage,
                    Responsibility = EvaluationConstants.Responsibility.High,
                    СommunicationSkills = EvaluationConstants.СommunicationSkills.MoreAverage
                },
                new Evaluation
                {
                    Id     = "d9bf4736-9e9d-471d-9677-6efa4542569b",
                    UserId = "5590cddb-be86-46f1-ad34-08a32a2bde2c",
                    EvaluatedUserName = "Rick_Sanchez",
                    Performance = EvaluationConstants.Performance.MoreAverage,
                    Qualification = EvaluationConstants.Qualification.MoreAverage,
                    Responsibility = EvaluationConstants.Responsibility.MoreAverage,
                    СommunicationSkills = EvaluationConstants.СommunicationSkills.MoreAverage
                },
                new Evaluation
                {
                    Id     = "a5c21bbb-2773-4a16-a12b-64bda1c5866b",
                    UserId = "f426e379-8148-4d20-9637-96cb34cb6b3f",
                    EvaluatedUserName = "Rick_Sanchez",
                    Performance = EvaluationConstants.Performance.VeryHigh,
                    Qualification = EvaluationConstants.Qualification.VeryHigh,
                    Responsibility = EvaluationConstants.Responsibility.VeryHigh,
                    СommunicationSkills = EvaluationConstants.СommunicationSkills.VeryHigh
                },
                new Evaluation
                {
                    Id     = "3658459a-8c0f-4495-9522-245185488a00",
                    UserId = "efc6ea69-3394-4d00-a733-104964b2ca6f",
                    EvaluatedUserName = "Rick_Sanchez",
                    Performance = EvaluationConstants.Performance.LessAverage,
                    Qualification = EvaluationConstants.Qualification.MoreAverage,
                    Responsibility = EvaluationConstants.Responsibility.LessAverage,
                    СommunicationSkills = EvaluationConstants.СommunicationSkills.MoreAverage
                },
                new Evaluation
                {
                    Id     = "3001490b-999a-4a6a-89b7-375787245119",
                    UserId = "93b5fec0-bab2-4221-bd18-e8b3736cb9a3",
                    EvaluatedUserName = "Rick_Sanchez",
                    Performance = EvaluationConstants.Performance.MoreAverage,
                    Qualification = EvaluationConstants.Qualification.LessAverage,
                    Responsibility = EvaluationConstants.Responsibility.MoreAverage,
                    СommunicationSkills = EvaluationConstants.СommunicationSkills.LessAverage
                },
                new Evaluation
                {
                    Id     = "b4dcb2e7-5de0-43ef-8efa-70b16f2b811c",
                    UserId = "d01baff7-d8f5-40f9-8798-b25b1549c890",
                    EvaluatedUserName = "Rick_Sanchez",
                    Performance = EvaluationConstants.Performance.VeryLow,
                    Qualification = EvaluationConstants.Qualification.VeryLow,
                    Responsibility = EvaluationConstants.Responsibility.VeryLow,
                    СommunicationSkills = EvaluationConstants.СommunicationSkills.VeryLow
                },
                new Evaluation
                {
                    Id     = "3819186d-6895-43a5-83fc-1d6eb7265291",
                    UserId = "7e56449f-a598-471d-9666-c0ac017319d7",
                    EvaluatedUserName = "Rick_Sanchez",
                    Performance = EvaluationConstants.Performance.LessAverage,
                    Qualification = EvaluationConstants.Qualification.LessAverage,
                    Responsibility = EvaluationConstants.Responsibility.LessAverage,
                    СommunicationSkills = EvaluationConstants.СommunicationSkills.LessAverage
                },
                new Evaluation
                {
                    Id     = "a7e08b2a-ecc1-4a98-bf2a-75cf6d66e936",
                    UserId = "27fa3bc7-616b-4af5-9cbe-aac818e638da",
                    EvaluatedUserName = "Rick_Sanchez",
                    Performance = EvaluationConstants.Performance.VeryHigh,
                    Qualification = EvaluationConstants.Qualification.MoreAverage,
                    Responsibility = EvaluationConstants.Responsibility.VeryHigh,
                    СommunicationSkills = EvaluationConstants.СommunicationSkills.MoreAverage
                },
                new Evaluation
                {
                    Id     = "9d264910-9f91-4373-a577-7ebeb2848232",
                    UserId = "7f5f5479-93e1-4948-9dfa-b597488019b5",
                    EvaluatedUserName = "Rick_Sanchez",
                    Performance = EvaluationConstants.Performance.MoreAverage,
                    Qualification = EvaluationConstants.Qualification.MoreAverage,
                    Responsibility = EvaluationConstants.Responsibility.MoreAverage,
                    СommunicationSkills = EvaluationConstants.СommunicationSkills.MoreAverage
                },
                new Evaluation
                {
                    Id     = "cec5fc2d-fd23-4aa3-8256-235fda6c6a46",
                    UserId = "116cd90a-de19-45c1-8719-0f7e7fa2e16c",
                    EvaluatedUserName = "Rick_Sanchez",
                    Performance = EvaluationConstants.Performance.LessAverage,
                    Qualification = EvaluationConstants.Qualification.LessAverage,
                    Responsibility = EvaluationConstants.Responsibility.LessAverage,
                    СommunicationSkills = EvaluationConstants.СommunicationSkills.LessAverage
                },
                new Evaluation
                {
                    Id     = "356374b2-17be-4ab6-af8f-bb2b3c309c90",
                    UserId = "ad4a4c05-9ae1-49ac-a117-d1015ae478cc",
                    EvaluatedUserName = "Rick_Sanchez",
                    Performance = EvaluationConstants.Performance.High,
                    Qualification = EvaluationConstants.Qualification.High,
                    Responsibility = EvaluationConstants.Responsibility.High,
                    СommunicationSkills = EvaluationConstants.СommunicationSkills.High
                },
                new Evaluation
                {
                    Id     = "cc853e51-111a-4dea-9b02-32d984091f9a",
                    UserId = "99a639c6-5dfa-411a-8997-505be7698b48",
                    EvaluatedUserName = "Rick_Sanchez",
                    Performance = EvaluationConstants.Performance.High,
                    Qualification = EvaluationConstants.Qualification.Low,
                    Responsibility = EvaluationConstants.Responsibility.LessAverage,
                    СommunicationSkills = EvaluationConstants.СommunicationSkills.High
                },
                new Evaluation
                {
                    Id     = "f393f673-779f-4b1d-b03a-7b7d3a6c8cc2",
                    UserId = "9feb3ed4-1176-44a9-aea0-5cefdf77b9b4",
                    EvaluatedUserName = "Rick_Sanchez",
                    Performance = EvaluationConstants.Performance.High,
                    Qualification = EvaluationConstants.Qualification.LessAverage,
                    Responsibility = EvaluationConstants.Responsibility.MoreAverage,
                    СommunicationSkills = EvaluationConstants.СommunicationSkills.High
                },
                new Evaluation
                {
                    Id     = "774d243e-4772-4d76-b98b-c9ff733bbd3d",
                    UserId = "9a6532d3-5d7a-4c5a-a088-211c4dc40648",
                    EvaluatedUserName = "Rick_Sanchez",
                    Performance = EvaluationConstants.Performance.MoreAverage,
                    Qualification = EvaluationConstants.Qualification.High,
                    Responsibility = EvaluationConstants.Responsibility.VeryHigh,
                    СommunicationSkills = EvaluationConstants.СommunicationSkills.MoreAverage
                },
                new Evaluation
                {
                    Id     = "4a2a9d9b-a31a-46d2-97ab-c574289f11ce",
                    UserId = "d9de3f01-c253-4130-875b-c9d527c9ab0d",
                    EvaluatedUserName = "Rick_Sanchez",
                    Performance = EvaluationConstants.Performance.High,
                    Qualification = EvaluationConstants.Qualification.MoreAverage,
                    Responsibility = EvaluationConstants.Responsibility.High,
                    СommunicationSkills = EvaluationConstants.СommunicationSkills.VeryHigh
                },
            };
        }
    }
}
