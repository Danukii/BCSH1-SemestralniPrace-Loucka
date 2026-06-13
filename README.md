# BCSH1-SemestralniPrace-Loucka
Jednoduchá databázová aplikace - ***TODO list*** (správa úkolů):

• sledované entity – *úkoly*, *uživatelé*, *štítky* (labely)

• každý úkol má *název, popis, datum vytvoření, termín splnění, stav* (hotovo / nehotovo)

• **každý úkol** může být přiřazen **jednomu uživateli** a může mít **více štítků**

• základ aplikace = 🧠CRUD -> umožňuje:

---> Create → **přidat úkol / uživatele / štítky**

---> Read → **zobrazit úkoly**

---> Update → **upravit úkoly**

---> Delete → **smazat úkoly**

• aplikace umožňuje **filtrovat úkoly** podle *uživatele, štítku a stavu*

• aplikace umožňuje **vyhledávat úkoly podle názvu**

• aplikace umožňuje **označit úkol jako splněný**

• data jsou ukládána do souboru **TodoApp/bin/Debug/net10.0-windows/data.json**

<---------------------------------------------------------------------------------->

<img width="914" height="644" alt="todoapp-uvod" src="https://github.com/user-attachments/assets/19e2dcc9-c557-4ef5-8278-b5996e24ec42" />

<---------------------------------------------------------------------------------->

<img width="916" height="647" alt="todoapp-1" src="https://github.com/user-attachments/assets/8d8ce237-816d-4617-8a5c-799051aed36c" />

<---------------------------------------------------------------------------------->

<img width="672" height="442" alt="todoapp-2" src="https://github.com/user-attachments/assets/a18b7d91-97da-4bd4-b330-e0a25105ca69" />

<---------------------------------------------------------------------------------->

<img width="923" height="647" alt="todoapp-3" src="https://github.com/user-attachments/assets/be7dd0d5-6aa2-4f49-9273-c6d960bac6fa" />

<---------------------------------------------------------------------------------->

<img width="922" height="648" alt="todoapp-3-filtrovani" src="https://github.com/user-attachments/assets/80cd569f-3aea-44c1-ae09-a8cb246079e9" />

<---------------------------------------------------------------------------------->

***Celý flow aplikace:***

✔️ **Spustíš appku**

---> Načtou se data z *data.json*

---> Pokud jde o první spuštění, zobrazí se uvítací obrazovka

✔️ **Načtení hlavního okna**

---> načtou se úkoly, uživatelé a štítky

---> Naplní se seznam úkolů (FlowLayoutPanel (úkoly)) a filtry (ComboBox a CheckedListBox)

✔️ **Přidání úkolu**

---> Kliknutí na **Přidat úkol**

---> Otevře se formulář pro zadání údajů

---> Uživatel vyplní název, popis, datum splnění, uživatele, štítky, progress apod.

---> Úkol se uloží a zobrazí v seznamu

✔️ **Zobrazení úkolů**

---> Úkoly se zobrazují jako kartičky

---> Každá kartička obsahuje název, popis, stav, datum a progress

✔️ **Detail úkolu**

---> Kliknutím na úkol se otevře detail

---> Zobrazí se všechny informace o úkolu

✔️ **Úprava úkolu**

---> Z detailu nebo tlačítkem Upravit

---> Otevře se formulář s předvyplněnými daty

---> Po uložení se změny promítnou do seznamu

✔️ **Smazání úkolu**

---> Kliknutí na Smazat

---> Zobrazí se potvrzovací dialog

---> Po potvrzení se úkol odstraní

✔️ **Správa uživatelů a štítků**

---> Lze přidávat a mazat uživatele a štítky

---> Nové položky se automaticky objeví ve filtrech

✔️ **Filtrování a vyhledávání**

---> Filtrování podle uživatele, štítku a stavu

---> Vyhledávání podle názvu úkolu

---> Tlačítko pro zrušení všech filtrů

✔️ **Uložení dat**

---> Po každé změně se data ukládají do JSON souboru

---> Po opětovném spuštění aplikace zůstávají zachována

✔️ **Statistiky**

---> Procento dokončených úkolů
