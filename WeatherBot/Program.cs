
int main(String args) 
{
    string Token = @"G:\Local repo\SensetiveData\Token.env";
    string UserID = @"G:\Local repo\SensetiveData\UserID.env";
    string city = "Санкт-Петербург";
    String messageText = getWeatherForecast(city);
    return 0;
}
String getWeatherForecast(String location) 
{
    return "Привет, Игорь!";
}
bool CurrentTime(string TargetTime)
{
string time = DateTime.Now.ToString("HH:mm");
return TargetTime == time;
}
string targetTime = "21:40";
if (CurrentTime(targetTime) == true) 
{ 
    string == 
}