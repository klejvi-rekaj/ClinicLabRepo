# ClinicLabApp 🏥

Nje aplikacion i plote per menaxhimin e laboratoreve klinike i ndertuar me .NET dhe C#.

## 📋 Permbajtja
- [Kerkesat para fillimit](#kerkesat-para-fillimit)
- [Udhezuesi i Instalimit](#udhezuesi-i-instalimit)
- [Struktura e Projektit](#struktura-e-projektit)
- [Si te fillosh](#si-te-fillosh)
- [Rrjedha e Zhvillimit](#rrjedha-e-zhvillimit)
-

## 🛠️ Kerkesat para fillimit

Para se te fillosh, sigurohu qe ke te instaluara keto ne kompjuterin tend:

- **Visual Studio** (me .NET Desktop Development workload)
- **Git bash** - Shkarko nga [https://git-scm.com](https://git-scm.com)
- **.NET Framework** (versioni i pershtatshem)

## 📥 Udhezuesi i Instalimit

### Hapi 1: Klono Repository-n

1. **Merr URL-ne e repository-t**
   - Shko te repository i projektit: [https://github.com/klejvi-rekaj](https://github.com/klejvi-rekaj)
   - Kliko butonin e gjelber **Code**
   - Kopjo HTTPS URL-ne (shembull: `https://github.com/username/ClinicLabApp.git`)

2. **Hap Git Bash**
   - Navigo te direktoria qe deshiron:
   ```bash
   cd "C:\Users\EmriJuaj\Desktop"
   ```
   *(Zevendeso `EmriJuaj` me emrin tuaj te perdoruesit te kompjuterin tuaj)*

3. **Klono projektin**
   ```bash
   git clone https://github.com/username/ClinicLabApp.git
   ```

### Hapi 2: Hap ne Visual Studio

1. Hap **Visual Studio**
2. Kliko **Open a project or solution**
3. Navigo te folderi i projektit te klonuar
4. Zgjidh file-in `.sln` (p.sh., `ClinicLabApp.sln`)

## 🏗️ Struktura e Projektit

Pas hapjes ne Visual Studio, duhet te shfaqen keto foldera:

```
ClinicLabApp/
├── Application/          # Logjika e biznesit dhe modelet
├── DataAccess/          # Shtresa e qasjes ne databaze
├── Presentation/        # Format e nderfaqes se perdoruesit (UI)
├── Properties/          # Vetite e projektit
├── Resources/           # Resurset e aplikacionit
└── ClinicLabApp.sln    # File-i i solution-it
```

**Shenim:** Nese folderet nuk shfaqen, shko te **Solution Explorer** → **Show All Files**

## 🚀 Si te fillosh

### Konfigurimi fillestar

1. **Nderto projektin**
   - Shtyp `Ctrl + Shift + B` ose shko te **Build** → **Build Solution**
   - Sigurohu qe nuk ka gabime kompajlimi

2. **Verifiko qe gjithçka funksionon**
   - Kontrollo qe te gjitha varesite jane zgjidhur
   - Ekzekuto aplikacionin per te testuar funksionalitetin baze



## 🔄 Rrjedha e Zhvillimit

### Komandat e rendesishme Git

```bash
# Merr ndryshimet me te fundit para se te fillosh punen
git pull origin main

# Kontrollo statusin e ndryshimeve te tua
git status

# Shto ndryshimet e tua
git add .

# Bej commit ndryshimet e tua
git commit -m "Mesazhi yt pershkrues i commit-it"

# Push ndryshimet e tua
git push origin main
```

### Udhezimet e Zhvillimit

- **Gjithmone bej pull** ndryshimet me te fundit para se te fillosh punen
- **Testo plotesisht** para se te besh push ndryshimet
- **Perdor mesazhe pershkruese commit-i**
- **Mos ndrysho strukturen e projektit** pa miratimin e liderit te grupit

## 🤝 Kontributi

### Para se te besh ndryshime

1. Krijo nje branch te ri per feature-in tend:
   ```bash
   git checkout -b feature/emri-i-feature-it-tend
   ```

2. Bej ndryshimet dhe testo plotesisht

3. Bej commit dhe push branch-in tend:
   ```bash
   git add .
   git commit -m "Shto: pershkrimi i ndryshimeve te tua"
   git push origin feature/emri-i-feature-it-tend
   ```

4. Krijo nje Pull Request ne GitHub



## ⚠️ Shenime te rendesishme

- **MOS** ndrysho strukturen e projektit pa u konsultuar me anetaret e grupit
- **GJITHMONE** bej pull ndryshimet me te fundit para se te fillosh punen: `git pull`
- **KURRE** mos bej push pa u siguruar qe gjithçka funksionon siç duhet
- **TESTO** ndryshimet e tua lokalisht para se te besh push

## 🐛 Zgjidhja e Problemeve

### Problemet e zakonshme

**Gabimet e Build-it:**
- Sigurohu qe te gjitha paketat NuGet jane restauruar
- Kontrollo qe ke versionin e duhur te .NET
- Provo te pastrosh dhe te rindertosh: **Build** → **Clean Solution** → **Build Solution**
- 

**Problemet me Git:**
- Nese ke konflikte merge, konsultohu me anetaret e grupit
- Perdor `git status` per te pare gjendjen aktuale
- Perdor `git log --oneline` per te pare commit-et e fundit




**Kodim të këndshem! 🎉**
  
