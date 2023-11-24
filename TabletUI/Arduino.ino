import serial
import matplotlib.pyplot as plt

ser = serial.Serial('COM8', 9600) 

satisfaccion = [0, 0, 0, 0, 0]
total_evaluaciones = 0

plt.ion()  

try:
    while True:
        data = ser.readline().decode().strip()
        if data.startswith("Empleado "):
            empleado = int(data.split()[1]) - 1
            satisfaccion[empleado] += 1
            total_evaluaciones += 1
            promedio_satisfaccion = sum(satisfaccion) / total_evaluaciones
            plt.bar(range(1, 6), satisfaccion)
            plt.title('Niveles de Satisfacción de Empleados')
            plt.xlabel('Nivel de Satisfacción')
            plt.ylabel('Número de Evaluaciones')
            plt.show()
            plt.pause(0.1)

except KeyboardInterrupt:
    ser.close()
    plt.ioff()

