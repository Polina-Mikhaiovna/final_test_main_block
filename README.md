# Контрольная работа по основному блоку
## Выполнила Полина Умрилова [@Oldfathw](t.me/Oldfathw)

**Задача:**

Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

*Примеры:*

*[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]*

*[“1234”, “1567”, “-2”, “computer science”] → [“-2”]*

*[“Russia”, “Denmark”, “Kazan”] → []*

### Запуск

Папка src содержит исходный код консольной программы, вы можете выбрать 2 варианта работы программы:

1. Не указывая аргументов. Будет использован заданный массив *[“Hello”, “2”, “world”, “:-)”, “1234”, “1567”, “-2”, “computer science”]*

**Запуск из ./src *dotnet run***

2. С аргументом --byhand. Пользователь получит доступ к введению массива строк через консоль

**Запуск из ./src *dotnet run -- --byhand***

Чтобы вызвать справку - *dotnet run -- -h* или *--help*

### Ссылка на Блок-схему алгоритма решения [здесь](https://viewer.diagrams.net/?tags=%7B%7D&target=blank&highlight=0000FF&edit=_blank&layers=1&nav=1&title=%D0%94%D0%B8%D0%B0%D0%B3%D1%80%D0%B0%D0%BC%D0%BC%D0%B0%20%D0%B1%D0%B5%D0%B7%20%D0%BD%D0%B0%D0%B7%D0%B2%D0%B0%D0%BD%D0%B8%D1%8F.drawio#R7Vxtc5s4EP41zFw%2FJAMSEPgYv6S9q9vrTdrm%2BhGDjLlg5GKcxPfrTxISSIAxdvyWq2cyBFZCWmn32V2tkDXYn728T7359BMOUKwBPXjR4EADwHF0cqWEVU4wTZATwjQKcpJREu6jfxEn8vfCZRSghVIxwzjOorlK9HGSID9TaF6a4me12gTHaq9zL0Q1wr3vxXXqQxRkUz4scFPSP6AonIqeDdvNS2aeqMxHsph6AX6WSHCowX6KcZbfzV76KKZzJ%2Bbl4ffVQzx6tN%2F%2F8dfip%2Fet9%2FHr5%2B9XeWN327xSDCFFSbZz0yicOqvv3z97S9dYje6th3ix4K%2FoT1685POlATsmnfSmBh1ytuLzaP9c0nH2JjjJrhZMyrekggHnRFF6ZTm5C9n%2Fga65Br322H1vyK63V9rA0ByDXS1Gyq99diXs6OzmjlXQpTehRNGlV%2FqMTvrtC87H6es4582QmaRzoBLnr56U3q0YFGEbSPfF0Mj9nZgHh11v1Me%2BmDdSM3%2FXlWYSSm0aamt9qQtDXItmgSSCogKoCeJWVDBrzPdFazmFXKHEKhBsDKTWABcfvXe78tkwOe0M98UrpqSRjsRMoXgt0sn5ZHqr8GmJdkhRro0Op5f9yj0avFnOtqzSoMISlMZWET%2BQRtiTUXEtKfC81F%2BgaC7I0AtDeTaLCcEgt4ssxY%2Boj2OcEkqCE0Q1O4rjCmkx9%2FwoCQnBKp%2B%2B4jkhXBFuYe95GmXontBpV8%2FEqRAafkLpJGbWcxoFAUoILcXLJEDUOukcQ3feLIqpn%2FmA4ieURb7HC7hbMSDt8RFl%2FpQz7S%2FTJ3QXZVnOESX9E4UhGyUoxr3RcnILS5gk8yL5DW5J3yM8Q1m6IlVEKTecK%2FXxufQwhstpU9m72Jzoca8WFi2XlpvccOO9hSGHDYa8InIUEMfIH3GaTXGIEy8eltSKRMo6I8zEy2YXZdmKi8NbZljVoXMQ4gIvUx%2B1TJWIQrw0RFlLPT6DdNpaVSJFsZdFT2q8sXcBG3UBy7aCGokbyQwIp1tTgjgmkRdaA9ODi7LBnhwKohCqGAUNGAUNGN0HRL%2BlX1fjT6bf%2F2h%2BGn2yfiajsP8LQLQClT1iFtQx2zjH4JQQBWuD6SB6elXgSHwznXirp1nkbR2nURglt2nq0cGxFnVaOAQ0nHD7RKwxFk8DHoaIQrCu4BmnZG21ppAwePWuLKRsFFEGG50aJ%2B95wAl6Vkd7z8qvh7N5ttp%2F3H%2BAAUUEBkR9igHox%2Bjusd7dgSapYsfIUnlObwn%2BvThGMQ5Tb0aXTyiNCNZQWi37UhZsdEzRCxJ5huM4Kg3AyWQCfL8WJZOSwB7bln1APwYqfsxocGSwyZEVFffuyW4unqyLJ1vvoTp4MvtInqyxc8OsSfjH8L5RyCNvjGJVMF4chWSBN%2FDJjDFEU2UnoolvecGMLAFzHUDE5nhj1h7VgjkmhosNJrf8hxVyDYNFFpKzpBVBoyz%2B9ZBYi%2BEr%2Fdqw8pY6C5A39gXntlxUwZPJgihOVcJFn7sLHZwHrMk8p6u%2F6fvXlnj8wZtjD4MX5WmlHT6BcHpzAF5rD9irIogSFTje6tomfI%2Bu%2Bh6xprrrWN%2B29Yqm5hzsVW9hfWH1%2Bc%2BLrdoE9DZj5dxYriJIoc9nbL1qSsCCbWB7MxpA8qhVXjpdj1ASkgiqqinpFM%2FGy8U5pEho5OkFbmA1RZ4eMg3YqiHdrNT6yNOtZFDceuRZIF6OPJ1DBZ7uWXiot%2Blp7I6exjlp4FmH8SXwbDXm7iZbrltvzJLbNRWQ811WLyICKmx31cKzbAe82PSuNt1s2Lo6rk13Gmz6fpJgRdbQ6j3mecRcPerqdNhk3KMGeuzvmCm4c9DzwEPOpDFrZvsOGk%2BOqOcW7KjnB9v%2BERb9ErzsELwYTsfo5VgbQK1cqouQHPtVh6TI8RcHq2VW0gz6qfdqjS4rjSS4pR8o0oAz9haLyFelpooYvUSZlNUiTz94PXpf5rTog0hprUuFFWmy%2F1UqrCvEjTUrFElZrAZdEbRdA1%2FxWcE6xyKayMfJ32rJlZkVpTerEVY%2BEbWGts3hVRm2QXsOz67m8MARcnigy8cRW%2BHtDDFwKpU1qzG%2FtaPKVlWj1tAald2bltS3pS6Z3tZoCLb63Sv9Guquocp0Lyon8jhqo0fIAl8yhK%2FYi%2BqaIgQnzRHC%2BkLqkiNsNwMbk4QqXM8%2BRQjrjuAUMP%2FFtqq7mgd4rA%2Blm3u3LkHCVtYhB1NrkPC2rAOo7yCwLyHFTgFPmIpg9rJNsPnjeds5dUYG1HNr85Ro1G8iy%2F%2BuJk3xFWqA%2FeWMzcYmsY5zjzAaH1fOXT8uPUCavLKiu7E6yvlg20GwftAll7O0E0LPlprSYZeBdAJvt6OEA3FiTz5uN5SODFrSWT1bOuYIpFdajkt2OSy420nByqlEmQdDnMDtq%2BPqdIywnO4LsHYAlmlXgGU2AOvmqF9tw7pbRElQj4zO9ITYAZycpcrIaXJyR90jhPvfdiiWKMoCpVyvrFmiNG9XsC8DtdYtC%2FIgHeZ4y8udrvsRcM2nucdJ7lY3up2qcu66H%2BEY3ZK7W39TXLGMrnGE%2FQWznjN6LbBKgBiuChF7a4QUKDW2Q%2BnbRJYI8c4cWRZsVtStkWU5GyC6J2RZJmxkeEdkkcfyx23y6uUvBMHhfw%3D%3D)
