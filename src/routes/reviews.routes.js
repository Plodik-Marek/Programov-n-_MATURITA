import expres from "express";

import * as reviewsController from "../controllers/reviews.controller.js";

const router = expres.Router();

router.get("/", reviewsController.getReviews);
router.get("/:id", reviewsController.getReview);
router.post("/", reviewsController.addReview);
router.put("/:id", reviewsController.updateReview);
router.delete("/:id", reviewsController.deleteReview);

router.get("/place/:placeId", reviewsController.getReviewsByPlace);

export default router;
