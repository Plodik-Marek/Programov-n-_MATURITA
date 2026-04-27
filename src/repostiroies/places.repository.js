import { pool } from "../db.js";

export async function getPlaces() {
  const [data] = await pool.execute("SELECT * FROM places");
  return data;
}

export async function getPlace(id) {
  const [data] = await pool.execute("SELECT * FROM places WHERE id = ?", [id]);
  return data[0];
}

export async function addPlace(place) {
  console.log(place);
  const [data] = await pool.execute(
    "INSERT INTO places VALUES (default, ?, ?, ?, ?, ?)",
    [place.place, place.type, place.description, place.address, place.FK_city_id],
  );
 
}

export async function updatePlace(id, data) {
  const [newData] = await pool.execute(
    "UPDATE places SET place = ?, type = ?, description = ?, address = ?, FK_city_id = ? WHERE id = ?",
    [data.place, data.type, data.description, data.address, data.FK_city_id, id],
  );
}

export async function deletePlace(id) {
  const [data] = await pool.execute("DELETE FROM places WHERE id = ?", [id]);
  
}

export async function getPlacesByCity(cityId) {
  const [data] = await pool.execute("SELECT * FROM places WHERE FK_city_id = ?", [cityId]);
  return data;
}
