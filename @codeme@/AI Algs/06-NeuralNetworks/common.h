/*
 *  Artificial Life Simulation Types and Symbolic Constants
 *
 *  ./software/ch7/common.h
 *
 *  mtj@cogitollc.com
 *
 */

#ifndef __COMMON_H
#define __COMMON_H

#include <math.h>
#include <stdlib.h>

/* Sensor Input Cells */

#define HERB_FRONT	0
#define CARN_FRONT	1
#define PLANT_FRONT	2
#define HERB_LEFT	3
#define CARN_LEFT	4
#define PLANT_LEFT	5
#define HERB_RIGHT	6
#define CARN_RIGHT	7
#define PLANT_RIGHT	8
#define HERB_PROXIMITY	9
#define CARN_PROXIMITY	10
#define PLANT_PROXIMITY	11

#define MAX_INPUTS	12


/* Output Cells */
 
#define ACTION_TURN_LEFT	0
#define ACTION_TURN_RIGHT	1
#define ACTION_MOVE		2
#define ACTION_EAT		3

#define MAX_OUTPUTS	4


/* Total number of weights (and biases) for an agent */

#define TOTAL_WEIGHTS	((MAX_INPUTS * MAX_OUTPUTS) + MAX_OUTPUTS)


/* Description of the 3 planes for the 2d grid */

#define HERB_PLANE	0
#define CARN_PLANE	1
#define PLANT_PLANE	2


/* Available directions */

#define NORTH	0
#define SOUTH	1
#define EAST	2
#define WEST	3

#define MAX_DIRECTION	4


/* Types for location, plants and agents */

typedef struct {
  short x;
  short y;
} locType;

typedef struct {
  locType location;
} plantType;

typedef struct {
  short type;
  short energy;
  short parent;
  short age;
  short generation;
  locType location;
  unsigned short direction;
  short inputs[MAX_INPUTS];
  short weight_oi[MAX_INPUTS * MAX_OUTPUTS];
  short biaso[MAX_OUTPUTS];
  short actions[MAX_OUTPUTS];
} agentType;

#define TYPE_HERBIVORE	0
#define TYPE_CARNIVORE	1
#define TYPE_DEAD	-1

typedef struct {
  short y_offset;
  short x_offset;
} offsetPairType;


/* Grid offsets for Front/Left/Right/Proximity (North/-South facing) */

const offsetPairType northFront[]=
      {{-2,-2}, {-2,-1}, {-2,0}, {-2,1}, {-2,2}, {9,9}};
const offsetPairType northLeft[]={{0,-2}, {-1,-2}, {9,9}};
const offsetPairType northRight[]={{0,2}, {-1,2}, {9,9}};
const offsetPairType northProx[]=
      {{0,-1}, {-1,-1}, {-1,0}, {-1,1}, {0,1}, {9,9}};

/* Grid offsets for Front/Left/Right/Proximity (West/-East facing) */

const offsetPairType westFront[]=
      {{2,-2}, {1,-2}, {0,-2}, {-1,-2}, {-2,-2}, {9,9}};
const offsetPairType westLeft[]={{2,0}, {2,-1}, {9,9}};
const offsetPairType westRight[]={{-2,0}, {-2,-1}, {9,9}};
const offsetPairType westProx[]=
      {{1,0}, {1,-1}, {0,-1}, {-1,-1}, {-1,0}, {9,9}};


/* Macro Function Definitions */

#define getSRand()	((float)rand() / (float)RAND_MAX)
#define getRand(x)	(int)((x) * getSRand())

#define getWeight()	(getRand(9)-1)


/* Parameters that can be adjusted */

#define MAX_FOOD_ENERGY		15
#define MAX_ENERGY		60
#define REPRODUCE_ENERGY	0.9

#define MAX_AGENTS	36

#define MAX_PLANTS	35

#define MAX_GRID	30

#define MAX_STEPS	1000000

#endif /* __COMMON_H */
