# TerraQuest 🌍

Приложение "География мира".

Проект позволяет хранить информацию о странах:

- название;
- столица;
- флаг;
- регион;
- население;
- площадь;
- валюта;
- официальные языки;
- год получения языком официального статуса;
- интересные географические факты.

## Технологии

- C#
- ASP.NET Core Web API
- Entity Framework Core
- SQLite
- JSON

## Реализовано

- создание базы данных через EF Core migrations;
- загрузка данных стран из JSON;
- связь many-to-many между странами и языками;
- хранение информации об официальных языках;
- хранение флагов стран.

## Источники

### Флаги стран

Основная часть флагов взята из репозитория [country-flags](https://github.com/hampusborgos/country-flags).

Флаг Абхазии взят с [Wikimedia Commons](https://commons.wikimedia.org/wiki/File:Flag_of_the_Republic_of_Abkhazia.svg).

Флаг Непала: автор Χ, [Wikimedia Commons](https://commons.wikimedia.org/wiki/File:Flag_of_Nepal_(white_background,_aspect_ratio_3-2).svg), лицензия CC BY-SA 4.0.

Флаг Южной Осетии взят с [Wikimedia Commons](https://commons.wikimedia.org/wiki/File:Flag_of_South_Ossetia.svg).

Флаги используются в образовательных целях.