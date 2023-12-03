# ControlWork
## Условие задачи
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []

## Методология
Для решения данной задачи достаточно создать функцию, которая будет для начала считать сколько элементов в заданном массиве соответсвует критериям, из чего станет известно сколько элементов будет в новом массиве. После этого в новой массив методом перебора изначльного записываем в новой массив удволетворительные элементы изначального массива.
После этого новый массив передаём в функцию, которая будет выводить массив на экран. Перед этим необходима проверка положилось ли в наш массив хоть что-то, тогда можно просто вывести [], как указано в условии задачи. 
Для решения задачи составил данную блок-схему ![блок-схему](https://viewer.diagrams.net/?tags=%7B%7D&highlight=0000ff&edit=_blank&layers=1&nav=1&title=ControlWork.drawio#R%3Cmxfile%20pages%3D%224%22%3E%3Cdiagram%20name%3D%22%D0%A1%D1%82%D1%80%D0%B0%D0%BD%D0%B8%D1%86%D0%B0%201%22%20id%3D%22O2_8Qqms4wQui68Lgwdx%22%3E7V1bc5s4FP41zHQf7AEE2DwmcZpOm27byW5vLzsYZEwXIwfj2t5fvwIkc1MwicUtJsk4IARCR%2BdI5zsXWQA3q%2F2db6yXH5EFXUEWrb0AZoIsA6BI%2BF9YcohLZHGqxyW271hxmZQUPDj%2FQVIoktKtY8FNpmKAkBs462yhiTwPmkGmzPB9tMtWWyA32%2BrasGGh4ME03GLpN8cKlnHpVJ4k5e%2BgYy9py5JG%2BrcyaGXSk83SsNAuVQRuBXDjIxTER6v9DXRD6lG6xPe9feLq8cV86AVVbvjnyzsDbj%2Fuv%2F7YyX9%2F%2FSi%2B%2FXknjdT4Kb8Nd0s6TF42OFAKQAsThJwiP1giG3mGe5uUXvto61kwbEbEZ0mde4TWuFDChb9gEBzI6BrbAOGiZbByydViV0jvNmjrm%2BQ9THsGgk%2Bju%2F2Hr7tH%2FWq2mL1%2FHFGWMHwbBiX9JPXCvqQaIIS6g2gFA%2F%2BAK%2FjQNQLnd3bwDcJD9rFeQmZ8QCjNpnrZW6epjkmnz6JPMfy8miTH%2BnX0eVsYmYTuIRF3SyeAD2sjotcOi2NFGv%2BGfgD3pVQhV0dTbTyV9ORnGj%2BByPaIyuwuERSJcv8yJSSaeD5dP%2Fyl%2F3z4oj9%2B%2F2VJN5%2Fe394p8OdI7g83l3FpmpuZ%2FWyNm8veOkN1TZCBJEbE0FzclWvL%2BZ0ZCO1xG0581yZykS%2BAq%2FBt7fkbWVQEGb%2BGmD74I3qOODfMf%2B1odEa5u4AU103%2Bk1sWyAtGC2PluIe49g3yNsjFJIjq4dcwVqGckJe5wQPkQB9f%2BRPu8hfjW1bIQ5tYyI4N7Ahvhw14yF8ZburiJmKT8JKkrPfxBdfx4GiZukvSySXt2JhmB3nyZYvwW3inSIpHQdV009KYD98EvuPZ9Hl47ONHvqgZM%2Fph90HFf7OY3Bxawt0xF5DZEl7wjcOJVnAxg5iF0hT%2FJoe5uQSv6OvwEIu64brQRbZvrHDFNfQdLFqYkXLXPicXTk3XC2cPqTrEa%2FrW1bGsiMmPlJm%2Bp4zZG%2BAJHxQn8EldE7ik9GcGL5uZT8%2FgoK0pnPk6yvRC6K5MOkV35tI5rJdc18sF7jm%2FtUwW3%2FBZxkrWZQdzf%2B2LcgPLsdOfXlhK%2BMtuI7qrJ%2F2YqyY0psw2OLVQ1ouBrZ7BVnS6dHN6aMe7dKb6fT7hxrX34x56NlaBB3GpzMrxX830%2BuNEC9WQXd6GtkSr%2BRbrdU3YzyR9MtayRjNpUoRdQJHGE6kIu46mZP56qNZ3%2FR9UBV5qtwAAKBA%2B0v5EIxSH8FxMW9HmfkZHFOe5Wrkhq5%2BlJU0f67qaYWlZbdsOLPUezqpV2bljeFYvEP4AN0za3xtz6GbpZbiO7eFjE9MrspGFfOiYhntFLqwcy4qHBmKYaMyj54WDs0ZYHqLOxLZGFu3LOSXP8UePImlFSDvtWJIgjiU5KwbxWWXCkyd%2FRmQCIFXQYrHBLJAfmeMLnOEtYVkf%2BiQlYFJRSujk0xUpYXldB4%2BJ0BGPialONVNk69KLJoAaJwtTM0jthOOnJ%2BimtBec7D8XgWmbt5y8EvMc6Al%2BruQZbRJVA7q6U72LLq8p%2BCGz4IcEaotDUdpQpDAJ%2FcP38P6xSk9%2FkMdFJ7N95uxAzs6AKVUVMP6oO7r1Kl7GjhUIDCgq04RVNDXLKhJBrm%2BfqK%2BA0vr4IH4Drmo5JWpKOzSoha1xfK%2FqOeFqHdsDueeohVLrpNCA1sK82K5zrdVJTcpMackMx31Sqzw%2BSrdQJX3vAVV2E1WWqZekh958s86qXudogk%2FD2FRIRA9w7BAp0aVeDJESF%2Bf6bZuthkiJS7cq9UpcXkukROcsPRi%2FZ8CoKjJiJyhkT4NRUJulB%2FQ9YJ2CzNNotFsR66DoQ%2Bu2p%2FnIKTw8zaqqZSRhRAanu85mpW2TqCjqQtaCIB9rPGFDiM5SOTtnGhYqixp%2Fd%2FWLrKVyLlRNV8UcZ9Rg%2FVSKcu2hDou1wk2sR1iugZwLpeq6WFOeHoxOg9FpiJ3g2ZUhduLiUO4QO%2FFCg90QO%2FFCRA2krL4xZWQjyCxELdXn370QNyOomrHQseBVUMxYmGfNWkmSggd3eLXES9k80qln8dKp4oVHnRVGuYFgBsrdFNDIRW5vOJjhYhIVAPdEhWohO4ACSvqIuEvkrmfE%2FhyNjfRBcZcLD%2BKGrIqpFJ0GwoBbJgUGwmAyyaXJdR4IF6O2yPY6dPcbMhnShC0vBJnisY7BmhKzgt2AOpCbIJXWd%2FRSQL%2FmQxoT1PwWXuxZbEQ3KqQj2vAsRumREgsfBlvfSwlE43pAtI%2BdnKGLBopBw81yulqkVM9Yv2owsKLz5v3zCF%2FMfe62J%2BnIKTxW2s5bmNW%2Bq8iV5ULtVi6v2jMFVOWpgNIMjr74YZSi%2Bjn4YTrkhxncIoOxv5V43OjGnnSl1ZDcV2rhHynTLKaXxarpkWptUKdHu86XIpjTKp3SKZVOKap00dby%2BFMSptE289dRyfVt9KmEUkPsV82j9LwFVmGEezaM0RnRniH9rsgG%2Fckm%2Fmq0iX%2FRldX4lv0FIrK2eW6UiFrft51RqwI6SsKOSL%2FW91jl6oTvVqyyOoCznoKzIVGyY4lTrySjbUBlrzLzq222GhIlL92q1CtxGRIla3Nw5wI5JMaeWID65pvJlNRaARtJApjQUFwnBX0tuPtelOU1mua2eFLlTJrX6RvoN0fVmhdGyTpgqE5iqJLFIiYGfAWL%2BDcfT9y1r0mcwKAJdWnCVtuF0LudKqy5NV6ZTGVtTDi10VDeVwPUagDtlPViJkx4YdzyZnipu6XywllYyhTSk41w1Ekb0EQnOfcj0%2F%2BgMTRRvTZFtJjA8kwnDv3eTwuZ21VEm1M6%2FTzWY%2B%2FnXEmrZUl7zBQ65dqZPp%2B0%2BDT5pvJYp0u%2B8B3c%2Fg8%3D%3C%2Fdiagram%3E%3Cdiagram%20id%3D%227kV8dG_MvgMUqdSkUNFz%22%20name%3D%22%D0%A1%D1%82%D1%80%D0%B0%D0%BD%D0%B8%D1%86%D0%B0%202%22%3E7V3RbqM4FP2aPKYCbAh5bNpOV5qOVG2l3ZmnkRPchBXEWUJasl%2B%2FBmzAOE1oGoENkao0GBcC95zDub52OgJ3YfIYoc3qB%2FFwMLIMLxmB%2B5FlmRBA%2Bitt2ectkwlrWEa%2BxzqVDS%2F%2Bf5g1Gqx153t4K3SMCQlifyM2Lsh6jRex0IaiiLyL3V5JIJ51g5ZYanhZoEBu%2Fdv34lXe6lqTsv0P7C9X%2FMymM833hIh3ZleyXSGPvFeawMPIckYWSNAIzEZpm%2FgD7iJC4pPdeOcwucNBevP5fc3P%2B%2B38AxTXHuF1fKFjjn%2F8%2BdN5RIH772z%2B%2Ffssef5rbI4ZJN5QsGO3nd2yeM%2FjgD0aFrZJonhFlmSNgoeydRaR3drD6WnoiWdlnydCNrTRpI3%2F4DjeM4yhXUxo0yoOA7ZXvlp2A7ZkFy3wkc%2FPgYmiJY6P9AN5v%2FRaKidodi%2FLO%2FqISYjjaE%2B3Ixyg2H8TsYoY5JdFv0%2BFjPZlUbtskE05yDRS0%2Fvs1Uhfbyfl%2B%2Bkse32QgFCGOY3Z%2B8qP8csGZeF5pxLUMKRvOIpxcpkgsMNAi8H4vdQJk5N%2FVdEIx1A6TtbhON2yeJQxs7OYORpFCLJjs2eRA%2BxeRMzRXD5BQ%2Fm0hyyfQAoytTeIfjonoPdsNo%2Fou2X6bpsGqB5%2Faj426VsaHhQEOCDLCIW08wZHPr1KHNX3PZc7TlH41U8wd26diS63l0YvGO1qzmi7IaMnQ2a0LQU5RCmsc17bM2Nk38v09mlMkyxAdUSo9KSt0dKE%2FeAlz0q1JWZ3hPvMOcozPROfXmKJK8MQcCXhJVcc9lefgIwAnOLyOoebnDPt8fYg4p7QHAciSlDgL9f0%2FYKiJHuOp0T3Fyi4ZTtC3%2FNyQGJqGtA8O14KyU16%2F7I7as9SETqEuOP8qEtKMUDDzjJqOAZyWmrGxo1puKLcMK%2FUEjb5Ecnr6xb3Anay17yqXIsqZ3MXOxCVk4f%2F1kRlkeP0aFXkLGfqCqjgAzVXlTsPdhMJdbm1thwUpta5SKbHstWOViSc77ZqD28VlYeK6XYd2XO7xseYUcFzy4HS62lkNs2GTaez55YKcZbzYf93nhFzYn6cCtd3hf5ayqQ%2FHKY21OJxQUjOYyDzWMfkmV%2BGvkR2GhLZmg6ZyEC3rLUAZnuGzrhxRI636uX4NYo6ww1l75we0D2f7dAYXARohRPl4zOccf1MaIFmCS3oJKEFti1qoNmqBvZO5bhIVOtJmQtOMUNt9Nk5rCh8bTphs%2B6EuY5UM1pDNsKqZ7RT3Z9HblMjPGQfbMpV%2FDyhlRPZ3ylT6xDgczY8stiFWYxOMXWeQ%2BJprsLwk83t5am0VXG2cnJqy1Z%2Bz0%2Bz1RwyXS05S1A7bS2A2aptswWSj9sttSbiWWsfoneWzpKHRPsqPXDQ0iOXOJROGAtctjlgZonlz%2Bscj69BzpAgx6sleVklm3tYqYR%2BKYVs04dKsyf4pVZ9KB%2BA0smHyistWtB%2BGrBo%2F7O68Ss9GLUBbPM%2BYQfPt%2FanhglOPzOarqbq8Jlxjpjc5tP1i%2BMx9T3raLJAJRzDIvgBqwl%2BTqwqUM4%2FtdZKJ5ejxHnWpd7V6KWQqE24YPWsJswf6h2JWkXHflX3XV7UYENRG%2FSKCEsunLCpH7PsR11%2B2hMxLwY94Sfo1nQYo7ZMx7QhP0F3ixAVNh0i9hkXhuw55AqPOCPNPLq2Sx7lUbZE11NfAnRfgQmaTjoFg3YcULORtwKXrY68QciM2XW07UyY6V7xbywn0B2ynNhyrVjtGmIBzHanflnOdfj%2BS0ADBxZL6L16yWyQQU8N2UjyNkUVgX%2Fxgb7KP2lqJAe96AHKo8yKKz8HZptOshT%2BLtc98GmJfPqI2df5I1D3hQ%2BNxQdagxYfzRYcwE4WHEAX1lbQX1ccfAl2QB48OTGH5MAsZyXNKKiX0YF1c%2BC7InkvYRaJrbZUdFzQuXHdqVjUcah6HS%2FrZFuVLyT8Yq0HaFDrUQApQB6z0qQYW%2BSEjL3QNmTuWge4q3hRAqoxHbj9KWHc3amcgypbnbVrzzLIyrUDLs9yPH1YntVhSlh9vRXoyXff2vKApdI5aocVj4uMhsBaCd%2BGNQfbr8X58OCqzIz9zN6oS3mTU7dYYqnqF9hnfU%2F8%2BxKOjPIfx4CH%2FwE%3D%3C%2Fdiagram%3E%3Cdiagram%20id%3D%22fQTLc2BclWqvglGA9Utn%22%20name%3D%22%D0%A1%D1%82%D1%80%D0%B0%D0%BD%D0%B8%D1%86%D0%B0%203%22%3E7Vrfc6IwEP5reGwHCKA%2Bitreg3ftjJ253mOECLkCcWL81b%2F%2BAiQihBHrOC3Um3GQbNaE5Ntvd7OogVG8e6RwGf4kPoo0U%2Fd3GhhrpmlYwOJfqWSfS3o9IQgo9oVSIZjhdySEupCusY9WJUVGSMTwsiz0SJIgj5VkkFKyLastSFSedQkDpAhmHoxU6W%2FsszCX9s1eIf%2BBcBDKmQ1nkPfEUCqLlaxC6JPtkQhMNNPRTLCDGnC1VFb%2BgBElhDWqSeV4N0JRuvlyX%2FN5Hy4f4LB2ihJ2pTFfnjZPExBuJ%2FhtxKa9%2Fi9v4N0Jk9jAaC22XWwZ20sckM9hEU1CWUgCksBoUkhdStaJj9Jp%2BMRuoTMlZMmFBhf%2BRYzthY3BNSNcFLI4Er3qasUGrMiaeujE80vDhDRA7IQeyPXStRxNcN5eFjv6iEiMGN3zNkURZHhTtlUoTD446H0IMq4rULsuyIYKMkdqMM6uenod9or7gZtdJ4ohFDCnmG1DzNBsCTN4ttwFnQnpBlGGdtcBQQwDbGHG28JPGJL84ZGPcPRW42TW4zQUeBSY2RlmTncQOgQVEYss2e44Yk7H3Sc4033at%2Bw%2BgQIyT28gfzon4nvmzim%2FC9K7VQpQFX%2BefCzTWw4PjCIUkYDCmCsvEcV8lYhW%2B56LjiYKL%2FAOyczty5yuTC%2B%2FB6P7HWe0fSaje7fMaFsBGXO8dhleKqvXcd5RMYMWhdcqFw2rc2SM%2Bz0wfoPG%2FIG8v7yacDZ%2Fj%2BsSok6RsaeSsXadxo2QsXbxanjdo1UtzlM4R1EZGxjhIOH3Hscmi5gpu7AHo6HoiLHv52aAeHiG82y81BCWBCcs2xHb1exxLc4njbJK40MlREyinVlsaKb3nX5vWYZZorhonQ30R56ieJbndJOORiSLxYpb8kcMp2Q%2Bh7V9tdGpEeB7ehbrlj2LejpLSIsdi7TJT3UsxkC3%2F7uSM63sFBWVZNJ0YJzmhIejoQzzxwWbkMTz9apdxRrgOOVQk5tbKZscOGoyOdBb7Q0MNdForc8%2FlSU2Z5PmLTt9tdgNN%2Fw7PcWZD7UVmhZRr1on5Sc7hXpdPMjJZX0u1ThgdP%2Ba%2Fv7els0%2Fx33jnRg8b%2B1F63KKWipFW1Z9uSR4D%2FNy52E8keFcNFrx9DIhEKZvO3bJ9AHQL0gOGiaxDOtqk2RsybemI%2BnLKZMtRcW8BObjTbkGlvlQNy9%2B226e5fAEV6mYifzHzT7VTinh6zmaoM1O2darTtm8r3HLoM4t2%2B12yx16%2FX8y1Wl0uLedEql1VJ4TVYGWL6p84q3jDImmQ8k8B346b0OqBM59pdzXPxmsTLfhD0UyKhR%2F5QKTfw%3D%3D%3C%2Fdiagram%3E%3Cdiagram%20id%3D%22uBgr20-UHsub971soiff%22%20name%3D%22%D0%A1%D1%82%D1%80%D0%B0%D0%BD%D0%B8%D1%86%D0%B0%204%22%3E7V1tc5s4EP41%2FpgOIIThYxzn2ptpZ3rNzPX6qYMDsbkB48M4sfvrT4Bkoxc7JFCQhGc61AgZjHb30e6zK2UC7pL9x8zfrL6kQRhPLCPYT8B8YlmmDWz0X9FyqFqmU9ywzKIAdzo1PES%2FQtxo4NZdFIRbqmOepnEebejGx3S9Dh9zqs3PsvSF7vaUxvRTN%2F4y5BoeHv2Yb%2F0eBfmqanWt6an9UxgtV%2BTJpuNVVxKfdMZvsl35QfpSawL3E8uZWGDvT8BsUrTR%2F8Bdlqb5q91I52R%2FF8bF4JNxrZ77x%2FtvcHz3LFznHd3TunnY%2F2XdJW706dv81o7%2F%2B%2BG83OAHPfvxDg87HrL8QOQQBkgs%2BDTN8lW6TNd%2BfH9qnWXpbh2ExWPQg2enPp%2FTdIMaTdT4b5jnB6xj%2Fi5PUdMqT2J8tXpm8aCzr4%2BbtukuewwvvBD%2B%2FbmfLcP8Qj%2FYRA%2FYEf0YpkmYZwd0noWxn0fP9A%2F2scovj%2F3eJDLUF0utWyFbvJCRpLx5eTSK4%2B309Nmblcd7ThFOYi5k9rKK8vBh45fSeEEQJBLpc5jl4f6yUFsIAd%2FZtjCyvZxwwiTGv6phhGNILSdbN2OEDY1xOiJjhJyQ0WTpo1%2FnxGiIZosMfVoWn7aFgFj5o6lsU3xE0vDjOIzTZeYnqPMmzCL0lmHGXvt6uvCayT5F%2B5D4AYOZMHFWDC0s2tHNoqcNLdq0RmTSU07KiV%2FodWXYcGZM4Jy37wgJdV9KiFUJGafWAwkr9DBMVzfD7M%2Fg3vKM05O%2BphF6pZNeGQalV5y%2BVAiDv%2FUGlaEU5%2Fh6Q6ubx6nbAYXWIo377C9QHE9piR9HyzX6%2FIiUopzHC9OPUKB8iy8kURBUChkip8FflPcrVHJTDF85oHBWYNAF7MBRPP7y5Bg713XxvCW1B5ob44NpuDTYgOqsJ80kd0yfnrahDkpHiJwryA0EcpB4seMAOZMnk9apHiBXmVInKGc5nktpBaFnrjD3TrXj6a3KtbYcPylc52M0fcO72tkqTRa7rWR8lm3SuEH0tOZ0uw7vc7vGeaWRwOc2gXbzEfZXXg%2BHvb4mLhnkzPOY0c8qIiaGeT4UZi8l0ZqLpM%2Fy0oZcdnw0SGLHgLdjFYNnk%2BcwVTdkr6EhgzHxWiZPX2oTtpptE4D4dxgfHNrGe3XmyGDQOEM8Sv1cPZ5p1QJ4lIloj%2FZFGBoyo2ka0fI0sTYRbduc6ymiBRDSGGj2ioH6oRzPFldecKEzyI1%2BdwxLA1%2BfnrDJesJET%2BsRrcE7wpJHtGT60Wc%2BspyGjrDVlvdXyRG2eOZCG0fYahvRnCYCSHuh%2FaZv9vRTmR%2Bh3SRhaVcs1hh6Kp9zLNDDcy26uKCVCncRglt0RuWaN26ncjztQ%2FjXiqgtq5lquZVWTmmfbiiXkCW6WidkSUirkh86HQL7kXSywz%2F1kx%2FFzZAbgE%2Fne3zz6uxABR7dzBmudHPGe8DktqoAPt4Po%2B%2B77sYD1J7oMK38AGcZ3gZWNVWufrXSSMfzO3Tl5gnvGPOSCNSmBLA0yzJZ3qCgVsOxH%2FVrvx%2FUiPyuRdaiUeHLPGblP3kNFE7pwBhoYqCAL6fp1UAH8zqA1dTr6G1hk8ReB6372BZG7HQQ7eHofeJ0mBeXi%2FA0j7Ssv6aOCdCujg00XdZlj8rj4ClWXai3SoU7od5sGw%2FTlW57p5ppV03XHE7GlEQEGlfTgY6q6YpqEsu58vftFI2vklN8QYTZIIL2DN6RJG2yIoJ2q5DtppGx3Tb3pxTya7z8F3S0%2FrcO%2FEOWUpPaaVI%2FYupaQEI2chgj%2BDgjAh%2ByllDDKLZS4U68Ttu1mVW51yLmdmrHs5yvFJFEazWcUcDm0YFFKh%2FrxCbpRZWRQLmhAgwxA9Qyrq7r0UkdB%2FmJl9M65Vltk7Oucz120yW%2B%2FeV6ZNAUwRJfNZKxx5gQW68NDd52yQykUFLCloNFlKAmzG5aR9xfDCptdhYyc5mN07UjTs8S9TmbnlWhJozdQQRosp%2BmPUiha5fg1FvGoxM2xGZS%2BNBmPFi91vvaPCEb%2FaysH7s38pq8SUyXiMoUBCUKmjzUrtrCbrrZCLTGFFLwJLmgCKrcR4hrJi1B9FzrWRAKVTv6zbVLgt7nb8l%2BlWUoZN17iENuERwQDlglOJAjzukQDmBT2hqOKWcGeTe8zJkZQmkrR13D7gomLAhp6vpaj9VK8xw%2BYTIWhKmwfyQI4%2FAZCl0SY05HToTxwfYM7wonrSYyXs2IF1vLfmF3VYX8F2QYdGjwnqXce%2Fkk99%2F%2FNu5%2B%2Ffy2SzarP3efdsGvZ9EfyVIc9QWZK%2BGbt9ULlUAfnktcgbnYBCUyvClZ5q8Zw%2BNot5VNf35UJywvq1iOozXLS8xBwDTVqJ7F7umpLCh4C49UccU1jor%2BRrW5AL7z2RV%2B0gMRu42KQ%2FaffQ2ITNJxeCQSzoQqA9H5qb2BC9B2OZikLsClMakJebtLSmkpQ%2B5ygA2U8wSEouE5P8Xtrze76sQP8JicwZTURinvB4iBgPcDVFyWcd6SuiCADJMQQIOsymCqsVVmh8Q6qDLtcB7ymrAOmtIO4pflixgU5JovaHA3mSwAmN17%2BwUb7dCF1zrBQmDMRr%2BXeh5uexmXIaIdSwsiWlQHo%2FSMINgNQthP080gLo0JE4Syct6u%2FE3xMUgfd0k57q9Z46KS%2B%2BfFEGGpy%2FBC06ZrKyS3SMEyfWRW3m15vC%2BP8%2FIIi%2BOtw4Pp0RpNuYgEVmKuenXiYqdE5SqxC%2B5yE79a0yqxi6PCkXklms7aLtkY8A%2FmGAwXI6T45K7fFEuMR8cBd%2FU1Jr9jWdoFu7xy8cJB6WYd6ZDmSkyR5OYFsYgcE2nZN0vT%2FEJPEseiEV59SYOCkLj%2FHw%3D%3D%3C%2Fdiagram%3E%3C%2Fmxfile%3E).