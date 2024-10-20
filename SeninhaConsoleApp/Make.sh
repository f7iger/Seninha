#!/bin/bash


rm -rf seninha erro.log
mcs -out:seninha *.cs 2> erro.log
if [[ -e "erro.log" ]]
then
	echo -n "Erro na linha: "
	cat erro.log | egrep "[0-9]{2},[0-9]{,3}" -o
	cat erro.log
   exit 1
else
	mono seninha
fi
