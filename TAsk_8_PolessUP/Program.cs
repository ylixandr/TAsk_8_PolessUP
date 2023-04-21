static string RgbToHex(int r, int g, int b)
{
    // Округляем значения до ближайшего допустимого значения
    r = Math.Max(0, Math.Min(255, r));
    g = Math.Max(0, Math.Min(255, g));
    b = Math.Max(0, Math.Min(255, b));

    // Конвертируем значения RGB в шестнадцатеричную систему счисления
    string hex = r.ToString("X2") + g.ToString("X2") + b.ToString("X2");

    return hex;
}

string hex = RgbToHex(255, 255, 255);
Console.WriteLine(hex);
