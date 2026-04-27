import { pool } from "../db.js";

export async function getRaitings() {
  const [data] = await pool.execute("SELECT * FROM raitings");
  return data;
}

export async function getRaiting(id) {
  const [data] = await pool.execute("SELECT * FROM raitings WHERE id = ?", [id]);
  return data[0];
}

export async function addRaiting(raitings) {
  console.log(raitings);
  const [data] = await pool.execute(
    "INSERT INTO raitings VALUES (default, ?, ?)",
    [raitings.FK_place_id, raitings.raiting],
  );
  return data;
}

export async function updateRaiting(id, data) {
  const [newData] = await pool.execute(
    "UPDATE raitings SET FK_place_id = ?, raiting = ? WHERE id = ?",
    [data.FK_place_id, data.raiting, id],
  );
  return newData;
}

export async function deleteRaiting(id){
  const [data] = await pool.execute("DELETE FROM raitings WHERE id = ?", 
    [id]
  );
  return data;
}


export async function getRaitingsByPlace(placeId) {
  const [data] = await pool.execute("SELECT * FROM raitings WHERE FK_place_id = ?", [placeId]);
  return data;
}

export async function getAverageRaitingByPlace(placeId) {
  const [data] = await pool.execute("SELECT AVG(raiting) as average, COUNT(*) as count FROM raitings WHERE FK_place_id = ?",
  [placeId]);
  return data[0];
}