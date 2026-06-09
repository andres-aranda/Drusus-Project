# build-setup.ps1
# Script de empaquetado para generar el instalador de Drusus V2

$ErrorActionPreference = "Stop"

Write-Host "==============================================" -ForegroundColor Green
Write-Host "   Generador de Instalador para Drusus V2" -ForegroundColor Green
Write-Host "==============================================" -ForegroundColor Green

# 1. Limpiar directorios previos
Write-Host "[1/5] Limpiando carpetas temporales..." -ForegroundColor Cyan
if (Test-Path "publish_temp") { Remove-Item -Recurse -Force "publish_temp" }
if (Test-Path "setup_out") { Remove-Item -Recurse -Force "setup_out" }
if (Test-Path "DrususV2.Instalador\Resources\app.zip") { Remove-Item -Force "DrususV2.Instalador\Resources\app.zip" }

# 2. Publicar DrususV2
Write-Host "[2/5] Compilando y publicando la aplicación principal..." -ForegroundColor Cyan
dotnet publish DrususV2\DrususV2.csproj -c Release -f net10.0-windows -o publish_temp --self-contained false

# 3. Comprimir publicación a zip
Write-Host "[3/5] Creando archivo empaquetado app.zip..." -ForegroundColor Cyan
Compress-Archive -Path publish_temp\* -DestinationPath DrususV2.Instalador\Resources\app.zip -Force

# 4. Compilar instalador
Write-Host "[4/5] Compilando el instalador..." -ForegroundColor Cyan
dotnet publish DrususV2.Instalador\DrususV2.Instalador.csproj -c Release -f net10.0-windows -r win-x64 --self-contained false -p:PublishSingleFile=true -o setup_out

# 5. Mover instalador final a carpeta de salida limpia
Write-Host "[5/5] Organizando entregables..." -ForegroundColor Cyan
if (Test-Path "Instalador_DrususV2") { Remove-Item -Recurse -Force "Instalador_DrususV2" }
New-Item -ItemType Directory -Path "Instalador_DrususV2" | Out-Null
Copy-Item -Path "setup_out\DrususV2.Instalador.exe" -Destination "Instalador_DrususV2\Instalar_DrususV2.exe" -Force
Copy-Item -Path "DrususV2.Instalador\Resources\icono.ico" -Destination "Instalador_DrususV2\icono.ico" -Force

# Limpiar residuos temporales
if (Test-Path "publish_temp") { Remove-Item -Recurse -Force "publish_temp" }
if (Test-Path "setup_out") { Remove-Item -Recurse -Force "setup_out" }

Write-Host "==============================================" -ForegroundColor Green
Write-Host " ¡Instalador generado con éxito!" -ForegroundColor Green
Write-Host " Destino: Instalador_DrususV2\Instalar_DrususV2.exe" -ForegroundColor Green
Write-Host "==============================================" -ForegroundColor Green
