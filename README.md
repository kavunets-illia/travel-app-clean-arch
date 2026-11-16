# Туристичний додаток (Travel App) — Лабораторна робота №5

## Архітектура проєкту (Clean Architecture)
```
[ Presentation (CLI / Program.cs) ]
                 │
                 ▼
[ Application (UseCases) ] ──► [ Domain (Entities & Interfaces) ]
                 ▲
                 │
[ Infrastructure (JsonTravelRepository) ]
```

## Інструкція зі збірки та запуску
1. Перейдіть у каталог проєкту: `cd src/Presentation/Cli`
2. Запустіть проєкт командою: `dotnet run`
