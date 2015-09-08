define(['courses/student'], function (Student) {
	var Course = (function () {

		function calculateTotalScoreFor(student) {
			var result = this._formula(student);
			return result;
		}

		function returnTopStudentsSortedBy(sortBy, count) {
			if (!this._totalScores ||
				this._totalScores.length !== this._students.length) {
				this.calculateResults();
			}
			count = count || this._totalScores.length;
			var totalScores = this._totalScores.slice(0);
			totalScores.sort(sortBy);
			return totalScores.map(function (student) {
				var studentToReturn = Object.create(student.student);
				studentToReturn.totalScore = student.totalScore;
				return studentToReturn;
			}).slice(0, count);
		}

		function sortByExam(st1, st2) {
			return st2.student.exam - st1.student.exam;
		}

		function sortByTotalScore(st1, st2) {
			//descending sorted
			return st2.totalScore - st1.totalScore;
		}

		function Course(title, formula) {
			this._students = [];
			this._title = title;
			this._formula = formula;
		}

		Course.prototype = {
			addStudent: function (student) {
				if (!(student instanceof Student)) {
					throw {
						message: 'Trying to add an object that is not an instance of Student'
					};
				}
				this._students.push(student);
				return this;
			},
			calculateResults: function () {
				var i, len, student, studentTotalScore;
				this._totalScores = [];
				for (i = 0, len = this._students.length; i < len; i += 1) {
					student = this._students[i];
					studentTotalScore = calculateTotalScoreFor.call(this, student);
					this._totalScores.push({
						student: student,
						totalScore: studentTotalScore
					});
				}
				return this;
			},
			getTopStudentsByExam: function (count) {
				return returnTopStudentsSortedBy
					.call(this, sortByExam, count);
			},
			getTopStudentsByTotalScore: function (count) {
				return returnTopStudentsSortedBy
					.call(this, sortByTotalScore, count);
			}
		};

		return Course;
	}());


	return Course;
});