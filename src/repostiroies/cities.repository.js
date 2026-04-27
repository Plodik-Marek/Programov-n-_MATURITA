import { pool } from "../db.js";

export async function getCities() {
  const [data] = await pool.execute("SELECT * FROM cities");
  return data;
}

export async function getCity(id) {
  const [data] = await pool.execute("SELECT * FROM cities WHERE id = ?", [id]);
  return data[0];
}
