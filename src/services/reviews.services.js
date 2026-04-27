import * as reviewsRepository from "../repostiroies/reviews.repository.js";

export async function getReviews() {
  return await reviewsRepository.getReviews();
}

export async function getReview(id) {
  return await reviewsRepository.getReview(id);
}

export async function addReview(review) {
  return await reviewsRepository.addReview(review);
}

export async function updateReview(id, data) {
  return await reviewsRepository.updateReview(id, data);
}

export async function deleteReview(id) {
  return await reviewsRepository.deleteReview(id);
}

export async function getReviewsByPlace(placeId) {
  return await reviewsRepository.getReviewsByPlace(placeId);
}
