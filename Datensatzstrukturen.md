Datensatzstrukturen
===================

Beispiel Datei in Cloud

## Tabelle Reports
ReportID
OrdnerName
Version
EventType
EventTime
ReportType
Consent
ReportIdentifier
IntegratorReportIdentifier
WOW64
ResponseType
FriendlyEventName
ConsentKey
AppName
AppPath

## Tabelle Sigs
SigID
SigName
SigValue

## Tabelle DynamicSigs
DynamicSigID
DynamicSigName
DynamicSigValue

## Tabelle UI (vermutlich überflüssig)
"UI[2]=C:\Program Files (x86)\Microsoft Visual Studio 11.0\Common7\IDE\devenv.exe
UI[3]=Microsoft Visual Studio 2012 funktioniert nicht mehr
UI[4]=Windows kann online nach einer Lösung für das Problem suchen und versuchen, das Programm neu zu starten.
UI[5]=Online nach einer Lösung suchen und das Programm neu starten
UI[6]=Später online nach einer Lösung suchen und das Programm schließen
UI[7]=Programm schließen"

## Tabelle LoadedModule (zu dem Zeitpunkt gelaufene Dienste)
ModuleID
ModulePath

## Tabelle Reports-Sigs
ReportID
SigID