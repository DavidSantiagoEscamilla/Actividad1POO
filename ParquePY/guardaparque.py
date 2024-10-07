
class Guardaparque:
    def __init__(self, nombre="Guardaparque Desconocido", antiguedad=0, especialidad="Especialidad Desconocida"):
        self.nombre = nombre
        self.antiguedad = antiguedad
        self.especialidad = especialidad

    def __str__(self):
        return f"Guardaparque(Nombre={self.nombre}, Antiguedad={self.antiguedad}, Especialidad={self.especialidad})"
