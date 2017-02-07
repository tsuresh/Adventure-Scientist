using UnityEngine;
using System.Collections;

public class Questions : MonoBehaviour {

	public string[] hints = new string[]{
		"Click on the Cycus plant ",
		"Click on the snail on the Log",
		"Click on the paddy bug on the grass",
		"Click on the hawk on the tree",
		"Click on the butterfly sucking nectar",
		"Click on the elephant",
		"Click on the image of Carolus Linnaeous",
		"Click on the frog near the river",
		"Click on the mushroom growing on the rock near the river",
		"Click on the Sea anemone which is a Coelenterate",

		"Click on the book on the table",
		"Click on Fransesco Reddi's image",
		"Click on the Experimental setup on the blue colour table",
		"Click on the convex lens on the brown colour table",
		"Click on the optical Microscope on the shelf",
		"There is a rotting fruit on the fridgerator. Click on it",
		"Click on the milk bottle on the table",
		"Click on Alexander Flemings image",
		"Click on the syringe on the shelf",
		"Click on the bottle which contains Acetic Acid(vinegar),which is on the shelf",

		"Pick the objects for the experiment to check wheather theres starch on a leaf",
		"Click on the water beaker",
		"Click on the bunsen burner",
		"Next click on ethyl alcohol",
		"Click on the test tube which in includes alcohol",
		"Click on the leaf to take it out",
		"Click on the leaf which was taken out",
		"Click on the iodine liquid",
		"Click on the experimental set up which is kept on the floor",
		"Click on the image which is referred to photosynthesis"
	};
	public string[] questions = new string[]{
		"To what group does this plant belong to?",
		"To what group does the snail belong to",
		"How does the Paddy bug taking food?",
		"Number of chambers in the heart of a hawk are",
		"Select a major feature of Arthropoda",
		"What is the scientific name of an elephant?",
		"What theory did he introduce?",
		"What is not a basic feature of Amphibians?",
		"To what group does this Fungus belong to?",
		"Select a common feature of a Coelenterate",

		"What is the first step in the Scientific method?",
		"What scientific theory did he find?",
		"When considering the two bottles what type of experiments are they?",
		"What is the convex lens called when a handle is fixed?",
		"What should be the distance between the eye and the eye piece of Microscope?",
		"What is the most probable reason for the rotting of the fruit?",
		"Which micro-organism turns Lactose present in milk to Lactic Acid",
		"What did he discover?",
		"Select the live causative agent whose growth is inactivated",
		"Which micro-organism forms this?",

		"",
		"What are the chemical ingredients of water",
		"Why is the leaf boiled on water",
		"",
		"What happens if you put the leaf into alcohol",
		"",
		"What can you put onto the leaf to check whether there is starch in the leaf?",
		"Select the change that can be expected, after adding the solution to the leaf",
		"For what can we use this experimental set up?",
		"What is photosynthesis?"
	};
	public string[,] answers = new string[,]{
		{"Angiosperm","Non flowering plant","Bryophyta"},
		{"Mollusca","Arthropoda","Annelida"},
		{"Chewing","Sucking","Piercing and sucking"},
		{"Two","Three","Four"},
		{"Possess joined apendages","No segmented body","Possess a hard chitinious exoskeleton"},
		{"Varanus salvator","Elephas maximus","Gallus lafayetii"},
		{"Nomenclature of organisms","Classification of organisms according to body shape","Formation of cells"},
		{"Homoiothermic","No Limbs with fingers for locomotion","Three chambers in heart"},
		{"Ascomycetes","Basidiomycetes","Zygomycetes"},
		{"No Radial symmetry","Incomplete Alimentary canal","No soft body"},

		{"Conclusion","Observation","Forming a hypothesis"},
		{"Spontaneous Generation","Theory of evolution","Law of gravity"},
		{"Controlled experiment","Guarded experiment","Data experiment"},
		{"Simple microscope","Hand lens","Compound microscope"},
		{"1 cm","2 cm","3 cm"},
		{"Due to micro-organism activities","Due to air","Due to physical factors"},
		{"Lacto Bacillus","Ameoba","Pennicilium"},
		{"Pencilium Fungus","Lacto Bacillus","Streptococcus"},
		{"Measles","Mumps","All the above"},
		{"Yeast","Lacto Bacillus","Streptococcus"},

		{"","",""},
		{"Hydrogen and Oxygen","Oxygen and Cloreen","Nytrogen and Oxygen"},
		{"To provide Oxygen","To deactivate cells","To increase carbondioxide"},
		{"","",""},
		{"Chlorophylls would be destroyed","Cells would be deactivated","Leaf would be mined"},
		{"","",""},
		{"Benedict liquid","Iodine liquid","Zink Liquid"},
		{"Leaf becomes blue in colour","Leaf becomes brown colour","Leaf becomes green colour"},
		{"To check whether the oxygen is needed to photosynthesis","To check whether the starch is needed to photosynthesis","To check whether the sunlight is needed to photosynthesis"},
		{"The process that trees release water from it","The process that trees make food","The process that trees get oxygen"}
	};
	public int[] correctAnswers = new int[]{
		0, 0, 2, 2, 0, 1, 0, 0, 1, 2,
		1, 0, 1, 1, 0, 0, 0, 0, 2, 0,
		0, 0, 1, 0, 0, 0, 1, 1, 2, 1
	};

}