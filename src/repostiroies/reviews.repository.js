import { pool } from "../db.js";

export async function getReviews() {
  const [data] = await pool.execute("SELECT * FROM reviews");
  return data;
}

export async function getReview(id) {
  const [data] = await pool.execute("SELECT * FROM reviews WHERE id = ?", [id]);
  return data[0];
}

export async function addReview(review) {
  console.log(review);
  const [data] = await pool.execute(
    "INSERT INTO reviews (FK_place_id, message, username, created_at) VALUES (?, ?, ?, NOW())",
    [review.FK_place_id, review.message, review.username],
  );
  return data;
}

export async function updateReview(id, data) {
  console.log(id, data);
  const [newData] = await pool.execute(
    "UPDATE reviews SET FK_place_id = ?, message = ?, username = ? WHERE id = ?",
    [data.FK_place_id, data.message, data.username, id],
  );
  return newData;
}

export async function deleteReview(id) {
  const [data] = await pool.execute("DELETE FROM reviews WHERE id = ?", [id]);
  return data;
}

export async function getReviewsByPlace(placeId) {
  const [data] = await pool.execute("SELECT * FROM reviews WHERE FK_place_id = ?", [placeId]);
  return data;
}