import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ListbookingComponent } from './listbooking.component';

describe('ListbookingComponent', () => {
  let component: ListbookingComponent;
  let fixture: ComponentFixture<ListbookingComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ListbookingComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ListbookingComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
