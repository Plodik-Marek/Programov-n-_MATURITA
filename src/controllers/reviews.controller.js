import * as reviewsService from "../services/reviews.services.js";

export async function getReviews(req, res) {
  const reviews = await reviewsService.getReviews();
  res.json(reviews);
}

export async function getReview(req, res) {
  const review = await reviewsService.getReview(req.params.id);
  res.json(review);
}

export async function addReview(req, res) {
  const newReview = {
    FK_place_id: req.body.FK_place_id,
    message: req.body.message,
    username: req.body.username,
  };

  await reviewsService.addReview(newReview);
  res.json({ message: "Review added successfully" });
}

export async function updateReview(req, res) {
  const newData = {
    FK_place_id: req.body.FK_place_id,
    message: req.body.message,
    username: req.body.username,
  };

  await reviewsService.updateReview(req.params.id, newData);
  res.json({ message: "Review updated successfully" });
}

export async function deleteReview(req, res) {
  await reviewsService.deleteReview(req.params.id);
  res.json({ message: "Review deleted successfully" });
}

export async function getReviewsByPlace(req, res) {
  const reviews = await reviewsService.getReviewsByPlace(req.params.placeId);
  res.json(reviews);
}