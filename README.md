znsoftWarehouseManager.CF.WinCE
===============================

Программа для работы со складской ИБД 1С через ВебСервис WinCE .CF

Visual Studio 2008, разработка ведется против общепринятых правил на русском языке (обфускация кода для англоговорящих :) )

Для работы желательно наличие DeviceApi.dll т.к в ней происходит работа со сканером ШК

при отсутствии этой .dll работа идет через буфер обмена на C900

Проблеммы:

1. В режиме [STAThread] не на ПК не работает с буфером обмена соответсвенно эмулировать сканер на ПК еще не реализовано, возможно в будущем через serial port получится обрабатывать сканер . но пока не требуется

2. Необходимо перевести работу с хранением данных в формах списка товара из ListView в отдельный класс , дописав функции обработки и вывода данных




