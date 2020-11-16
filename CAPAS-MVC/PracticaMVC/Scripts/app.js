function ValidarFechas(dateIni, dateFin) {
    var _dateIni = new Date(dateIni);
    var _dateFin = new Date(dateFin);

    if (_dateFin < _dateIni) {
        return false;
    }
    else {
        return true;
    }
}