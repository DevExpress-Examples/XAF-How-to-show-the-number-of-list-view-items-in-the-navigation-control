;#DropDB ItemCountEasyTest

#Application ItemCountWin
#Application ItemCountWeb
#IfDef ItemCountWin

*Action About...
 
*Action OK

#EndIf

#IfDef ItemCountWeb
!Action Navigation(My Details)
#EndIf
