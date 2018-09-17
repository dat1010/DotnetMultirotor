import { PostService} from './../services/post.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent implements OnInit{
posts: any = {};

constructor(private postService: PostService) {}

  ngOnInit() {
		this.postService.getPosts().subscribe(posts => {
console.log("Posts:", posts);
this.posts = posts});
	}
}
