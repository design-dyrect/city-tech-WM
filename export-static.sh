#!/usr/bin/env bash
# Renders the ASP.NET Core site to plain HTML in ./static so it can be hosted on Vercel.
# Requires the site running locally: dotnet run --project CityTech.Web --launch-profile http
set -euo pipefail
BASE="${BASE:-http://localhost:5080}"
OUT=static
rm -rf "$OUT" && mkdir -p "$OUT/services"
cp -R CityTech.Web/wwwroot/. "$OUT/"
curl -sf "$BASE/" -o "$OUT/index.html"
for p in app-development web-development cost-management maintainance-support warranty-management; do
  curl -sf "$BASE/services/$p" -o "$OUT/services/$p.html"
done
echo "Exported to $OUT/"
