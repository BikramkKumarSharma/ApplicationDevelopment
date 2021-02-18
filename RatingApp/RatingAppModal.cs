using System.Collections.Generic;
using System.IO;

namespace RatingApp
{
    public class RatingAppModal
    {
        public string CustomerName { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string FoodQuality { get; set; }
        public string StaffFriendliness { get; set; }
        public string Cleanliness { get; set; }
        public string OrderAccuracy { get; set; }
        public string ResturantAmbiance { get; set; }
        public string ValueforMoney { get; set; }


        public int FoodQualityN { get; set; }
        public int StaffFriendlinessN { get; set; }
        public int CleanlinessN { get; set; }
        public int OrderAccuracyN { get; set; }
        public int ResturantAmbianceN { get; set; }
        public int ValueforMoneyN { get; set; }


        public void LoadRatingData(List<RatingAppModal> listData, string filePath)
        {
            listData.Clear();
            StreamReader reader = new StreamReader(filePath);
            do
            {
                string textLine = reader.ReadLine();
                if (textLine.Length > 0)
                {
                    CustomerName = textLine.Substring(0, textLine.IndexOf(","));
                    textLine = textLine.Remove(0, textLine.IndexOf(",") + 1);

                    ContactNumber = textLine.Substring(0, textLine.IndexOf(","));
                    textLine = textLine.Remove(0, textLine.IndexOf(",") + 1);

                    Email = textLine.Substring(0, textLine.IndexOf(","));
                    textLine = textLine.Remove(0, textLine.IndexOf(",") + 1);


                    FoodQuality = textLine.Substring(0, textLine.IndexOf(","));
                    textLine = textLine.Remove(0, textLine.IndexOf(",") + 1);

                    StaffFriendliness = textLine.Substring(0, textLine.IndexOf(","));
                    textLine = textLine.Remove(0, textLine.IndexOf(",") + 1);

                    Cleanliness = textLine.Substring(0, textLine.IndexOf(","));
                    textLine = textLine.Remove(0, textLine.IndexOf(",") + 1);

                    OrderAccuracy = textLine.Substring(0, textLine.IndexOf(","));
                    textLine = textLine.Remove(0, textLine.IndexOf(",") + 1);

                    ResturantAmbiance = textLine.Substring(0, textLine.IndexOf(","));
                    textLine = textLine.Remove(0, textLine.IndexOf(",") + 1);

                    ValueforMoney = textLine;

                    listData.Add(new RatingAppModal
                    {
                        CustomerName = CustomerName,
                        ContactNumber = ContactNumber,
                        Email = Email,
                        FoodQuality = FoodQuality,
                        FoodQualityN = GetRating(FoodQuality),
                        StaffFriendliness = StaffFriendliness,
                        StaffFriendlinessN = GetRating(StaffFriendliness),
                        Cleanliness = Cleanliness,
                        CleanlinessN = GetRating(Cleanliness),
                        OrderAccuracy = OrderAccuracy,
                        OrderAccuracyN = GetRating(OrderAccuracy),
                        ResturantAmbiance = ResturantAmbiance,
                        ResturantAmbianceN = GetRating(ResturantAmbiance),
                        ValueforMoney = ValueforMoney,
                        ValueforMoneyN = GetRating(ValueforMoney)
                    });
                }
            } while (reader.Peek() != -1);
            reader.Close();
        }

        public int GetRating(string value)
        {
            if (value.Equals("Excellent"))
                return 5;
            else if (value.Equals("Good"))
                return 3;
            else if (value.Equals("Average"))
                return 2;
            else
                return 1;
        }
    }
}
