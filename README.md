# Drusus-Project

Drusus-Project consiste en un programa administrador de cartera de clientes, 
el cual permite administrar las cuentas corrientes de los clientes, registra ventas y pagos; tanto en pesos como en USS.
Tambien tiene la funcion de administrar gastos, ver el debe y el haber de las cuentas.
Utiliza servicios de la API "Dolar hoy" para obtener las cotizaciones actuales del dolar en Argentina.

La estructura es en capas simple. La capa presentacion contiene los formularios con los que interactua el usuario mientras que la capa de datos
contiene la estructura del Entity Framework junto con la base de datos.
