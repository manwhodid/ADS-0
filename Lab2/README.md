# Лабораторная работа №2. Изучение структуры WinForms-приложений. Создание и обработка событий

Программа одновременно показывает время в Москве, Лондоне и Владивостоке (три `TextBox`),
поддерживает русский и английский интерфейс.

## Состав
| Файл | Назначение |
|---|---|
| `Lab2/Program.cs` | Функция запуска: выбор культуры (`ru` / `en`) до создания формы |
| `Lab2/Clock.cs` | Класс `Clock`: делегат `SecondTickHandler`, событие `SecondTick`, `System.Windows.Forms.Timer` (1000 мс или заданный интервал), словарь `Dictionary<string, TimeSpan>` смещений, `AddCity`, `GetTime` |
| `Lab2/MainForm.cs` | Форма: экземпляр `Clock` с тремя городами, обработчик `SecondTick` (`ToLongTimeString()` → `TextBox`), меню |
| `Lab2/MainForm.Designer.cs` | Разметка формы (`Anchor = Top, Bottom, Left, Right` у `TextBox`) |
| `Lab2/MainForm.resx` / `MainForm.en.resx` | Локализованные надписи формы (русский / английский) |

## Меню
* **&Часы / &Clock** (Alt+Ч / Alt+C)
  * **&Старт** — Ctrl+S
  * **Сто&п** — Ctrl+T
  * **&Выход** — Alt+F4
* **&Язык / &Language** — перезапуск программы на русском или английском

## Запуск
Открыть `Lab2.sln` в Visual Studio 2022 (нужен .NET 8 SDK) и нажать F5, или:
```
dotnet run --project Lab2            # русский интерфейс
dotnet run --project Lab2 -- en      # английский интерфейс
```
Английский язык задаётся в `Program.Main` так же, как в методичке:
`Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");`

Для отчёта: скриншоты окна на двух языках, код `Program.cs`, `Clock.cs`, `MainForm.cs`.
